using System;
using System.Collections.Generic;
using Configurations;
using Map.MapCells.Implementation;
using MapObjects.Enemies.Implementation;
using MapObjects.Obstacles.Implementation;
using MapObjects.Units.Implementation;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

namespace Map.Implementation
{
    public class MapModel : IInitializable, IDisposable
    {
        private readonly MapConfigurations _configurations;
        private readonly IFactory<Indices, MapCellModel> _cellFactory;
        private readonly UnitsProvider _unitsProvider;
        private readonly EnemiesProvider _enemiesProvider;
        private readonly ObstaclesProvider _obstaclesProvider;
        private MapCellModel[,] _cells;

        public event Action<Indices> MapCellViewRequested;

        public MapModel(MapConfigurations configurations, IFactory<Indices, MapCellModel> cellFactory,
            UnitsProvider unitsProvider, EnemiesProvider enemiesProvider, ObstaclesProvider obstaclesProvider)
        {
            _configurations = configurations;
            _cellFactory = cellFactory;
            _unitsProvider = unitsProvider;
            _enemiesProvider = enemiesProvider;
            _obstaclesProvider = obstaclesProvider;
        }

        public void Initialize()
        {
            _cells = new MapCellModel[_configurations.Rows, _configurations.Columns];
            for (var i = 0; i < _configurations.Rows; i++)
            {
                for (var j = 0; j < _configurations.Columns; j++)
                {
                    var indices = new Indices(i, j);
                    var cell = _cellFactory.Create(indices);
                    cell.OccupiedBy = ObjectType.None;
                    _cells[i, j] = cell;
                    // FillCellNeighbors(_cells, i, j, _configurations.Rows, _configurations.Columns);
                    MapCellViewRequested?.Invoke(indices);
                }
            }
            
            for (var i = 0; i < _configurations.Rows; i++)
            {
                for (var j = 0; j < _configurations.Columns; j++)
                {
                    FillCellNeighbors(_cells, i, j, _configurations.Rows, _configurations.Columns);
                }
            }
            
            FillMapWithObstacles();
        }

        public void SetupMap()
        { 
            // FillMapWithObstacles();
        }

        private void FillCellNeighbors(MapCellModel[,] cells, int row, int column, int maxRow, int maxColumn)
        {
            var cell = cells[row, column];
            var upCell = row + 1 < maxRow ? cells[row + 1, column] : null;
            var rightCell = column + 1 < maxColumn ? cells[row, column + 1] : null;
            var downCell = row - 1 >= 0 ? cells[row - 1, column] : null;
            var leftCell = column - 1 >= 0 ? cells[row, column - 1] : null;
            cell.FillNeighborsCells(upCell, rightCell, downCell, leftCell);
        }
        
        private void FillMapWithObstacles()
        {
            var visitedCells = new Queue<MapCellModel>();
            var currentCell = _cells[0, 1];
            visitedCells.Enqueue(currentCell);
            var largestColumn = 1;
            var emptyCellsAmount = 1;
            var bitShift = Random.Range(0, 3);
            while (largestColumn < _configurations.SecondUnitsColumn - 1)
            {
                var stepInfo = DoStep(currentCell, emptyCellsAmount, bitShift, visitedCells);
                if (stepInfo.Cell == null)
                {
                    Debug.Log($"Cell on {largestColumn} is failed");
                    break;
                }
                
                currentCell = stepInfo.Cell;
                emptyCellsAmount = stepInfo.EmptyCellsAmount;
                bitShift = stepInfo.BitShift;
                largestColumn = currentCell.Indices.Column;
            }

            currentCell = _cells[_configurations.Rows - 1, 1];
            visitedCells.Clear();
            visitedCells.Enqueue(currentCell);
            largestColumn = 1;
            emptyCellsAmount = 1;
            bitShift = Random.Range(0, 3);
            while (largestColumn < _configurations.SecondUnitsColumn - 1)
            {
                var stepInfo = DoStep(currentCell, emptyCellsAmount, bitShift, visitedCells);
                if (stepInfo.Cell == null)
                {
                    Debug.Log($"Cell on {largestColumn} is failed");
                    break;
                }
                
                currentCell = stepInfo.Cell;
                emptyCellsAmount = stepInfo.EmptyCellsAmount;
                bitShift = stepInfo.BitShift;
                largestColumn = currentCell.Indices.Column;
            }
        }

        private StepInfo DoStep(MapCellModel cell, int emptyCellsAmount, int bitShift, Queue<MapCellModel> visitedCells)
        {
            var tempAmount = emptyCellsAmount;
            var tempBitShift = bitShift;
            MapCellModel chosenCell = null;
            for (var i = 0; i < 3; i++)
            {
                var direction = (Direction) (1 << tempBitShift);
                tempBitShift = tempBitShift >= 2 ? 0 : tempBitShift + 1;
                var neighborCell = cell.GetNeighborCellOnDirection(direction);
                if (neighborCell == null || visitedCells.Contains(neighborCell))
                {
                    continue;
                }

                visitedCells.Enqueue(neighborCell);
                if (tempAmount > 0)
                {
                    chosenCell ??= neighborCell;
                    tempAmount--;
                    continue;
                }

                if (neighborCell.OccupiedBy == ObjectType.Obstacle)
                {
                    continue;
                }
                
                _obstaclesProvider.SpawnObstacle(neighborCell.Indices);
                neighborCell.OccupiedBy = ObjectType.Obstacle;
            }

            var newEmptyCellsAmount = emptyCellsAmount == 1 ? 2 : 1;
            tempBitShift = Random.Range(0, 3);
            return new StepInfo(chosenCell, tempBitShift, newEmptyCellsAmount);
        }

        public void Dispose()
        {
            
        }
    }
}
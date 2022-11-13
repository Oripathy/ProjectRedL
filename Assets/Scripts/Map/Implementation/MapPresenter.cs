using System.Collections.Generic;
using Base;
using Map.Interfaces;
using Map.MapCells.Interfaces;
using UnityEngine;

namespace Map.Implementation
{
    public class MapPresenter : Presenter<MapView>, IMap
    {
        private readonly IMapCellPool _mapCellPool;
        private List<List<IMapCell>> _mapCells;

        public MapPresenter(IMapCellPool mapCellPool)
        {
            _mapCellPool = mapCellPool;
        }

        public void SetupMap()
        {
            for (var i = 0; i < _mapCells.Count; i++)
            {
                for (var j = 0; j < _mapCells[0].Count; j++)
                {
                    _mapCells[i].Add(_mapCellPool.PoolObject(Vector3.zero));
                }
            }
        }
    }
}
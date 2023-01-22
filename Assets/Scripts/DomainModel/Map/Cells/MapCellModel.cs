using System.Collections.Generic;

namespace DomainModel.Map.Cells
{
    public class MapCellModel
    {
        private Indices _indices;
        private Dictionary<Direction, MapCellModel> _neighborsMap;

        public Indices Indices => _indices;
        public MapCellModel LeftCell { get; private set; }
        public MapCellModel RightCell { get; private set; }
        public MapCellModel UpCell { get; private set; }
        public MapCellModel DownCell { get; private set; }

        public ObjectType OccupiedBy { get; set; }

        public void Initialize(Indices indices)
        {
            _indices = indices;
        }

        public void FillNeighborsCells(MapCellModel upCell, MapCellModel rightCell, MapCellModel downCell,
            MapCellModel leftCell)
        {
            UpCell = upCell;
            RightCell = rightCell;
            DownCell = downCell;
            LeftCell = leftCell;
            if (_neighborsMap != null)
            {
                return;
            }
            
            _neighborsMap = new Dictionary<Direction, MapCellModel>
            {
                {Direction.Up, UpCell},
                {Direction.Right, RightCell},
                {Direction.Down, DownCell},
                {Direction.Left, LeftCell}
            };
        }

        public MapCellModel GetNeighborCellOnDirection(Direction direction)
        {
            if (_neighborsMap.TryGetValue(direction, out var cell))
            {
                return cell;
            }

            throw new KeyNotFoundException();
        }
    }
}
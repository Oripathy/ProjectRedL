using Map.MapCells.Implementation;

namespace Map.Implementation
{
    public struct StepInfo
    {
        public MapCellModel Cell { get; }
        public int BitShift { get; }
        public int EmptyCellsAmount { get; }

        public StepInfo(MapCellModel cell, int bitShift, int emptyCellsAmount)
        {
            Cell = cell;
            BitShift = bitShift;
            EmptyCellsAmount = emptyCellsAmount;
        }
    }
}
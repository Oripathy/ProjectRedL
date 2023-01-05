namespace Map.MapCells.Implementation
{
    public struct Indices
    {
        public int Row { get; }
        public int Column { get; }

        public Indices(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
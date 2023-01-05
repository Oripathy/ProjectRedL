using Map.MapCells.Implementation;

namespace Base
{
    public class MapObject
    {
        private Indices _indices;
        private ObjectType _objectType;

        public Indices Indices => _indices;
        public ObjectType ObjectType
        {
            get => _objectType;
            protected set => _objectType = value;
        }

        public void Initialize(Indices indices)
        {
            _indices = indices;
        }
    }
}
using Map.MapCells.Interfaces;
using UnityEngine;

namespace Map.MapCells.Implementation
{
    public class MapCellModel : IMapCell
    {
        private Vector3 _position;
        private int[] _indices;

        public Vector2 Position => _position;
        public int[] Indices => _indices;
        public ObjectType OccupiedBy { get; set; }

        public void Initialize(Vector3 position, int[] indices)
        {
            _position = position;
            _indices = indices;
        }

        public void SetActive(bool isActive)
        {
            throw new System.NotImplementedException();
        }

        public void SetPosition(Vector3 position)
        {
            throw new System.NotImplementedException();
        }
    }
}
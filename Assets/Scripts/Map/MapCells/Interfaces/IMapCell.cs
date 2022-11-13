using UnityEngine;

namespace Map.MapCells.Interfaces
{
    public interface IMapCell
    {
        public void SetActive(bool isActive);
        public void SetPosition(Vector3 position);
    }
}
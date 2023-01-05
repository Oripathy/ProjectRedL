using UnityEngine;

namespace MapObjects.Obstacles.Interfaces
{
    public interface IObstacle
    {
        public void SetActive(bool isActive);
        public void SetPosition(Vector3 position);
    }
}
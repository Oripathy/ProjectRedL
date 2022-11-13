using UnityEngine;

namespace Enemies.Interfaces
{
    public interface IEnemy
    {
        public void SetActive(bool isActive);
        public void SetPosition(Vector3 position);
    }
}
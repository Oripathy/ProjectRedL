using UnityEngine;

namespace Units.Interfaces
{
    public interface IUnit
    {
        public void SetActive(bool isActive);
        public void SetPosition(Vector3 position);
    }
}
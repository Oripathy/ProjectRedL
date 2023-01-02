using UnityEngine;

namespace Base
{
    public interface IPoolableObj
    {
        public void SetActive(bool isActive);
        public void SetPosition(Vector3 position);
    }
}
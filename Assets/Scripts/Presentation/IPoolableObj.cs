using UnityEngine;

namespace Presentation
{
    public interface IPoolableObj
    {
        public void SetActive(bool isActive);
        public void SetPosition(Vector3 position);
    }
}
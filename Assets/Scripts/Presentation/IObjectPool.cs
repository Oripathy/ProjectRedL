using UnityEngine;

namespace Presentation
{
    public interface IObjectPool<TObj>
        where TObj : IPoolableObj
    {
        public TObj PoolObject(Vector3 position);
        public void ReturnToPool(TObj obj);
    }
}
using System.Collections.Generic;
using Units.Interfaces;
using UnityEngine;
using Zenject;

namespace Units.Implementation
{
    public class UnitPool
    {
        private const int Capacity = 10;
        private readonly Queue<IUnit> _pool = new Queue<IUnit>(Capacity);
        private readonly IFactory<IUnit> _factory;

        public UnitPool(IFactory<IUnit> factory)
        {
            _factory = factory;
            for (var i = 0; i < Capacity; i++)
            {
                _pool.Enqueue(_factory.Create());
            }
        }

        public IUnit PoolObject(Vector3 position)
        {
            if (_pool.Count == 0)
            {
                Debug.LogWarning("Pool Is Empty. New IObj Has Been Created");
                return _factory.Create();
            }

            var unit = _pool.Dequeue();
            unit.SetActive(true);
            unit.SetPosition(position);
            return unit;
        }

        public void ReturnToPool(IUnit obj)
        {
            obj.SetActive(false);
            obj.SetPosition(Vector3.zero);
            _pool.Enqueue(obj);
        }
    }
}
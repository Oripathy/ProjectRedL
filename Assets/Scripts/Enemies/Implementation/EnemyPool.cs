using System.Collections.Generic;
using Enemies.Interfaces;
using UnityEngine;
using Zenject;

namespace Enemies.Implementation
{
    public class EnemyPool
    {
        private const int Capacity = 30;
        private readonly Queue<IEnemy> _pool = new Queue<IEnemy>(Capacity);
        private readonly IFactory<IEnemy> _factory;

        public EnemyPool(IFactory<IEnemy> factory)
        {
            _factory = factory;
            for (var i = 0; i < Capacity; i++)
            {
                _pool.Enqueue(_factory.Create());
            }
        }

        public IEnemy PoolObject(Vector3 position)
        {
            if (_pool.Count == 0)
            {
                Debug.LogWarning("Pool Is Empty. New IObj Has Been Created");
                return _factory.Create();
            }

            var enemy = _pool.Dequeue();
            enemy.SetActive(true);
            enemy.SetPosition(position);
            return enemy;
        }

        public void ReturnToPool(IEnemy obj)
        {
            obj.SetActive(false);
            obj.SetPosition(Vector3.zero);
            _pool.Enqueue(obj);
        }
    }
}
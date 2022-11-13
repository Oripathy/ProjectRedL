using System.Collections.Generic;
using Obstacles.Interfaces;
using UnityEngine;
using Zenject;

namespace Obstacles.Implementation
{
    public class ObstaclePool : IObstaclePool
    {
        private const int Capacity = 20;
        private readonly Queue<IObstacle> _pool = new Queue<IObstacle>(Capacity);
        private readonly IFactory<IObstacle> _factory;

        public ObstaclePool(IFactory<IObstacle> factory)
        {
            _factory = factory;
            for (var i = 0; i < Capacity; i++)
            {
                _pool.Enqueue(_factory.Create());
            }
        }

        public IObstacle PoolObject(Vector3 position)
        {
            if (_pool.Count == 0)
            {
                Debug.LogWarning("Pool Is Empty. New IObj Has Been Created");
                return _factory.Create();
            }

            var obstacle = _pool.Dequeue();
            obstacle.SetActive(true);
            obstacle.SetPosition(position);
            return obstacle;
        }

        public void ReturnToPool(IObstacle obj)
        {
            obj.SetActive(false);
            obj.SetPosition(Vector3.zero);
            _pool.Enqueue(obj);
        }
    }
}
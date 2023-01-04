using System.Collections.Generic;
using Base;
using Map.MapCells.Interfaces;
using UnityEngine;
using Zenject;

namespace Map.MapCells.Implementation
{
    public class MapCellPool : IObjectPool<MapCellView>
    {
        private const int Capacity = 50;
        private readonly Queue<MapCellView> _pool = new Queue<MapCellView>(Capacity);
        private readonly IFactory<MapCellView> _factory;

        public MapCellPool(IFactory<MapCellView> factory)
        {
            _factory = factory;
            for (var i = 0; i < Capacity; i++)
            {
                _pool.Enqueue(_factory.Create());
            }
        }

        public MapCellView PoolObject(Vector3 position)
        {
            if (_pool.Count == 0)
            {
                Debug.LogWarning("Pool Is Empty. New IObj Has Been Created");
                return _factory.Create();
            }

            var cell = _pool.Dequeue();
            cell.SetActive(true);
            cell.SetPosition(position);
            return cell;
        }

        public void ReturnToPool(IMapCell obj)
        {
            obj.SetActive(false);
            obj.SetPosition(Vector3.zero);
            _pool.Enqueue(obj);
        }
    }
}
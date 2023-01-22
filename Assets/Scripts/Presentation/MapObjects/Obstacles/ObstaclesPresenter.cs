using System;
using System.Collections.Generic;
using Base;
using DomainModel.Configurations;
using DomainModel.Map.Cells;
using DomainModel.MapObjects.Obstacles;
using UnityEngine;
using Zenject;

namespace Presentation.MapObjects.Obstacles
{
    public class ObstaclesPresenter : AsynchronousObj, IInitializable, IDisposable
    {
        private readonly ObstaclesProvider _obstaclesProvider;
        private readonly ObstacleConfigurations _configurations;
        private readonly IFactory<ObstacleView> _factory;
        private readonly Dictionary<Indices, ObstacleView> _obstacleViewsMap;

        public ObstaclesPresenter(ObstaclesProvider obstaclesProvider, ObstacleConfigurations configurations, IFactory<ObstacleView> factory)
        {
            _obstaclesProvider = obstaclesProvider;
            _configurations = configurations;
            _factory = factory;
            _obstacleViewsMap = new Dictionary<Indices, ObstacleView>();
        }

        public void Initialize()
        {
            _obstaclesProvider.ObstacleViewRequested += OnObstacleViewRequested;
        }

        public void Dispose()
        {
            _obstaclesProvider.ObstacleViewRequested -= OnObstacleViewRequested;
        }

        private void OnObstacleViewRequested(Indices indices)
        {
            if (_obstacleViewsMap.ContainsKey(indices))
            {
                Debug.Log($"Obstacle view already created at {indices}");
            }

            var view = _factory.Create();
            var x = indices.Column * 3 / 2f * view.Size.x;
            var y = view.Size.y;
            var z = indices.Row * 3 / 2f * view.Size.z;
            var position = new Vector3(x, y, z);
            view.transform.position = position;
            _obstacleViewsMap.Add(indices, view);
        }
    }
}
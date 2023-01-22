using System;
using System.Collections.Generic;
using DomainModel.Configurations;
using DomainModel.Map.Cells;
using Zenject;

namespace DomainModel.MapObjects.Obstacles
{
    public class ObstaclesProvider
    {
        private readonly ObstaclesProviderConfigurations _configurations;
        private readonly IFactory<Indices, ObstacleModel> _factory;
        private readonly List<ObstacleModel> _obstacles;

        public event Action<Indices> ObstacleViewRequested; 

        public ObstaclesProvider(ObstaclesProviderConfigurations configurations, IFactory<Indices, ObstacleModel> factory)
        {
            _configurations = configurations;
            _factory = factory;
            _obstacles = new List<ObstacleModel>(_configurations.MaxObstaclesAmount);
        }

        public void SpawnObstacle(Indices indices)
        {
            var obstacle = _factory.Create(indices);
            _obstacles.Add(obstacle);
            ObstacleViewRequested?.Invoke(indices);
        }
    }
}
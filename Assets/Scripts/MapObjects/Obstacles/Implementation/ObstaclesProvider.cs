using System;
using System.Collections.Generic;
using Configurations;
using Map.MapCells.Implementation;
using Zenject;

namespace MapObjects.Obstacles.Implementation
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
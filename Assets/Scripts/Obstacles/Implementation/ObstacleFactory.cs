using Containers;
using Obstacles.Interfaces;
using UnityEngine;
using Zenject;

namespace Obstacles.Implementation
{
    public class ObstacleFactory : IObstacleFactory
    {
        private readonly DiContainer _container;
        private readonly ObstacleConfigurations _configurations;

        public ObstacleFactory(DiContainer container, ObstacleConfigurations configurations)
        {
            _container = container;
            _configurations = configurations;
        }
        
        public IObstacle Create()
        {
            var randomIndex = Random.Range(0, _configurations.PrefabsCount);
            var prefab = _configurations.GetObstaclePrefab(randomIndex);
            var view = _container.InstantiatePrefabForComponent<ObstacleView>(prefab);
            var presenter = _container.Resolve<ObstaclePresenter>();
            presenter.SetView(view);
            return presenter;
        }
    }
}
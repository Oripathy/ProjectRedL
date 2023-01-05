using Configurations;
using Zenject;

namespace MapObjects.Obstacles.Implementation
{
    public class ObstacleViewFactory : IFactory<ObstacleView>
    {
        private readonly ObstacleConfigurations _configurations;
        private readonly DiContainer _container;

        public ObstacleViewFactory(ObstacleConfigurations configurations, DiContainer container)
        {
            _configurations = configurations;
            _container = container;
        }

        public ObstacleView Create()
        {
            var view = _container.InstantiatePrefabForComponent<ObstacleView>(_configurations.GetObstaclePrefab(0));
            return view;
        }
    }
}
using Configurations;
using Map.MapCells.Implementation;
using Zenject;

namespace MapObjects.Obstacles.Implementation
{
    public class ObstacleFactory : IFactory<Indices, ObstacleModel>
    {
        private readonly DiContainer _container;
        private readonly ObstacleConfigurations _configurations;

        public ObstacleFactory(DiContainer container, ObstacleConfigurations configurations)
        {
            _container = container;
            _configurations = configurations;
        }
        
        public ObstacleModel Create(Indices indices)
        {
            var model = _container.Instantiate<ObstacleModel>();
            model.Initialize(indices);
            return model;
        }
    }
}
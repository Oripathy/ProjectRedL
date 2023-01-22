using DomainModel.Configurations;
using DomainModel.Map.Cells;
using Zenject;

namespace DomainModel.MapObjects.Obstacles
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
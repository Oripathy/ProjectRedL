using Configurations;
using Map.MapCells.Implementation;
using Zenject;

namespace MapObjects.Enemies.Implementation
{
    public class EnemyFactory : IFactory<Indices, EnemyModel>
    {
        private readonly DiContainer _container;
        private readonly EnemiesConfigurations _configurations;

        public EnemyFactory(DiContainer container, EnemiesConfigurations configurations)
        {
            _container = container;
            _configurations = configurations;
        }

        public EnemyModel Create(Indices indices)
        {
            var model = _container.Instantiate<EnemyModel>();
            model.Initialize(indices);
            return model;
        }
    }
}
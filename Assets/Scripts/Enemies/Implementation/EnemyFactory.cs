using Containers;
using Enemies.Interfaces;
using Zenject;

namespace Enemies.Implementation
{
    public class EnemyFactory : IEnemyFactory
    {
        private readonly DiContainer _container;
        private readonly EnemiesConfigurations _configurations;

        public EnemyFactory(DiContainer container, EnemiesConfigurations configurations)
        {
            _container = container;
            _configurations = configurations;
        }

        public IEnemy Create()
        {
            var view = _container.InstantiatePrefabForComponent<EnemyView>(_configurations.EnemyPrefab);
            var presenter = _container.Resolve<EnemyPresenter>();
            presenter.SetView(view);
            return presenter;
        }
    }
}
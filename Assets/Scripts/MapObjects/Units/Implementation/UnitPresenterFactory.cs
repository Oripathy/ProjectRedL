using Configurations;
using Map.MapCells.Implementation;
using Zenject;

namespace MapObjects.Units.Implementation
{
    public class UnitPresenterFactory : IFactory<Indices, UnitPresenter>
    {
        private readonly UnitConfigurations _configurations;
        private readonly DiContainer _container;

        public UnitPresenterFactory(UnitConfigurations configurations, DiContainer container)
        {
            _configurations = configurations;
            _container = container;
        }

        public UnitPresenter Create(Indices indices)
        {
            var view = _container.InstantiatePrefabForComponent<UnitView>(_configurations.UnitPrefab);
            var presenter = _container.Instantiate<UnitPresenter>();
            presenter.SetIndices(indices);
            presenter.SetView(view);
            presenter.Initialize();
            return presenter;
        }
    }
}
using Containers;
using Map.MapCells.Interfaces;
using Zenject;

namespace Map.MapCells.Implementation
{
    public class MapCellFactory : IFactory<IMapCell>
    {
        private readonly DiContainer _container;
        private readonly MapCellConfigurations _configurations;

        public MapCellFactory(DiContainer container, MapCellConfigurations configurations)
        {
            _container = container;
            _configurations = configurations;
        }

        public IMapCell Create()
        {
            var view = _container.InstantiatePrefabForComponent<MapCellView>(_configurations.MapCellPrefab);
            var presenter = _container.Instantiate<MapCellPresenter>();
            var model = _container.Instantiate<MapCellModel>();
            presenter.SetModel(model);
            presenter.SetView(view);
            return model;
        }
    }
}
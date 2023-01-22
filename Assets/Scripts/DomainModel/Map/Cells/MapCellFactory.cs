using Zenject;

namespace DomainModel.Map.Cells
{
    public class MapCellFactory : IFactory<Indices, MapCellModel>
    {
        private readonly DiContainer _container;

        public MapCellFactory(DiContainer container)
        {
            _container = container;
        }

        public MapCellModel Create(Indices indices)
        {
            var model = _container.Instantiate<MapCellModel>();
            model.Initialize(indices);
            return model;
        }
    }
}
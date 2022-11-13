using Containers;
using Units.Interfaces;
using UnityEngine.Scripting;
using Zenject;

namespace Units.Implementation
{
    public class UnitFactory : IUnitFactory
    {
        private readonly DiContainer _container;
        private readonly UnitConfigurations _configurations;

        public UnitFactory(DiContainer container, UnitConfigurations configurations)
        {
            _container = container;
            _configurations = configurations;
        }

        public IUnit Create()
        {
            var view = _container.InstantiatePrefabForComponent<UnitView>(_configurations.UnitPrefab);
            var presenter = _container.Resolve<UnitPresenter>();
            presenter.SetView(view);
            return presenter;
        }
    }
}
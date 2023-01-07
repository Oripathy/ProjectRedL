using System;
using System.Collections.Generic;
using Map.MapCells.Implementation;
using Zenject;

namespace MapObjects.Units.Implementation
{
    public class UnitsPresenterHolder : IInitializable, IDisposable
    {
        private readonly IFactory<Indices, UnitPresenter> _factory;
        private readonly UnitsProvider _unitsProvider;
        private readonly List<UnitPresenter> _units;

        public UnitsPresenterHolder(IFactory<Indices, UnitPresenter> factory, UnitsProvider unitsProvider)
        {
            _factory = factory;
            _unitsProvider = unitsProvider;
            _units = new List<UnitPresenter>();
        }

        public void Initialize()
        {
            _unitsProvider.UnitViewRequested += OnUnitViewRequested;
        }

        private void OnUnitViewRequested(Indices indices)
        {
            var unit = _factory.Create(indices);
            _units.Add(unit);
        }

        public void Dispose()
        {
            _unitsProvider.UnitViewRequested += OnUnitViewRequested;
            foreach (var unit in _units)
            {
                unit.Dispose();
            }
        }
    }
}
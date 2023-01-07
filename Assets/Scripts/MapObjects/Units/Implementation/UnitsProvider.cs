using System;
using System.Collections.Generic;
using Configurations;
using Map.MapCells.Implementation;
using Zenject;

namespace MapObjects.Units.Implementation
{
    public class UnitsProvider
    {
        private readonly UnitsProviderConfigurations _configurations;
        private readonly IFactory<Indices, UnitModel> _factory;
        private readonly List<UnitModel> _units;

        public event Action<Indices> UnitViewRequested;

        public UnitsProvider(IFactory<Indices, UnitModel> factory, UnitsProviderConfigurations configurations)
        {
            _factory = factory;
            _configurations = configurations;
            _units = new List<UnitModel>(_configurations.MaxUnitsAmount);
        }

        public void SpawnUnit(Indices indices)
        {
            var unit = _factory.Create(indices);
            _units.Add(unit);
            UnitViewRequested?.Invoke(indices);
        }
    }
}
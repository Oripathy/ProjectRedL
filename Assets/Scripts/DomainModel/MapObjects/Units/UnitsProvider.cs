using System;
using System.Collections.Generic;
using DomainModel.Configurations;
using DomainModel.Map.Cells;
using Zenject;

namespace DomainModel.MapObjects.Units
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
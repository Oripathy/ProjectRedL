﻿using Configurations;
using Map.MapCells.Implementation;
using Zenject;

namespace MapObjects.Units.Implementation
{
    public class UnitFactory : IFactory<Indices, UnitModel>
    {
        private readonly DiContainer _container;
        private readonly UnitConfigurations _configurations;

        public UnitFactory(DiContainer container, UnitConfigurations configurations)
        {
            _container = container;
            _configurations = configurations;
        }

        public UnitModel Create(Indices indices)
        {
            var model = _container.Instantiate<UnitModel>();
            model.Initialize(indices);
            return model;
        }
    }
}
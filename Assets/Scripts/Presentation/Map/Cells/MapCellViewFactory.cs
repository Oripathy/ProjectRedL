﻿using DomainModel.Configurations;
using Zenject;

namespace Presentation.Map.Cells
{
    public class MapCellViewFactory : IFactory<MapCellView>
    {
        private readonly DiContainer _container;
        private readonly MapCellConfigurations _configurations;

        public MapCellViewFactory(DiContainer container, MapCellConfigurations configurations)
        {
            _container = container;
            _configurations = configurations;
        }

        public MapCellView Create()
        {
            var view = _container.InstantiatePrefabForComponent<MapCellView>(_configurations.MapCellPrefab);
            return view;
        }
    }
}
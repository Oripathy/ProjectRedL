﻿using Containers;
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
            var model = _container.Instantiate<MapCellModel>();
            return model;
        }
    }
}
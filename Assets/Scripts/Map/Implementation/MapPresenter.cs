using System.Collections.Generic;
using Base;
using Map.Interfaces;
using Map.MapCells.Implementation;
using UnityEngine;
using Zenject;

namespace Map.Implementation
{
    public class MapPresenter : Presenter<MapView>, IMap
    {
        private readonly IFactory<MapCellView> _factory;
        private readonly MapModel _model;
        private readonly Dictionary<Indices, MapCellView> _cellViewsMap;

        public MapPresenter(MapModel model, IFactory<MapCellView> factory)
        {
            _model = model;
            _factory = factory;
            _cellViewsMap = new Dictionary<Indices, MapCellView>();
        }

        public override void Initialize()
        {
            base.Initialize();
            _model.MapCellViewRequested += OnMapCellViewRequested;
        }

        private void OnMapCellViewRequested(Indices indices)
        {
            if (_cellViewsMap.ContainsKey(indices))
            {
                Debug.Log($"Obstacle view already created at {indices}");
            }

            var view = _factory.Create();
            var x = indices.Column * 3 / 2f * view.Size.x;
            var z = indices.Row * 3 / 2f * view.Size.z;
            var position = new Vector3(x, 0f, z);
            view.transform.position = position;
            _cellViewsMap.Add(indices, view);
        }

        public override void Dispose()
        {
            base.Dispose();
            _model.MapCellViewRequested -= OnMapCellViewRequested;
        }
    }
}
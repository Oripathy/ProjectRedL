using Base;
using Map.MapCells.Interfaces;
using UnityEngine;

namespace Map.MapCells.Implementation
{
    public class MapCellPresenter : Presenter<MapCellView>
    {
        private IMapCell _model;

        public void SetModel(IMapCell model)
        {
            _model = model;
        }
        
        public void SetActive(bool isActive)
        {
            throw new System.NotImplementedException();
        }

        public void SetPosition(Vector3 position)
        {
            throw new System.NotImplementedException();
        }
    }
}
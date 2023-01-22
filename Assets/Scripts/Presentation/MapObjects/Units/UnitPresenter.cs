using System;
using DomainModel.Map.Cells;
using DomainModel.MapObjects.Units;
using UnityEngine;

namespace Presentation.MapObjects.Units
{
    public class UnitPresenter : Presenter<UnitView>
    {
        private readonly UnitsProvider _unitsProvider;
        private Indices _indices;

        public void SetIndices(Indices indices)
        {
            _indices = indices;
        }
        
        public void SetActive(bool isActive)
        {
            throw new NotImplementedException();
        }

        public void SetPosition(Vector3 position)
        {
            throw new NotImplementedException();
        }
    }
}
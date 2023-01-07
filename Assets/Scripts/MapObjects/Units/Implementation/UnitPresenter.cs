using System;
using Base;
using Map.MapCells.Implementation;
using UnityEngine;

namespace MapObjects.Units.Implementation
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
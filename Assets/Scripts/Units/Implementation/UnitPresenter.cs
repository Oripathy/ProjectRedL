using Base;
using Units.Interfaces;
using UnityEngine;

namespace Units.Implementation
{
    public class UnitPresenter : Presenter<UnitView>, IUnit
    {
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
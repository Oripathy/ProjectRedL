using Base;
using Enemies.Interfaces;
using UnityEngine;

namespace Enemies.Implementation
{
    public class EnemyPresenter : Presenter<EnemyView>, IEnemy
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
using Base;
using Obstacles.Interfaces;
using UnityEngine;

namespace Obstacles.Implementation
{
    public class ObstaclePresenter : Presenter<ObstacleView>, IObstacle
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
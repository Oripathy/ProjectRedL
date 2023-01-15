using System.Collections.Generic;
using Base;
using Map.Implementation;
using MapObjects.Obstacles.Implementation;
using UnityEngine;
using Zenject.SpaceFighter;

namespace Levels.Implementation
{
    public class LevelView : View
    {
        [SerializeField] private MapView _mapView;
        [SerializeField] private List<ObstacleView> _obstacleViews;
        [SerializeField] private List<EnemyView> _enemyViews;

        public MapView MapView => _mapView;
        public List<ObstacleView> ObstacleViews => _obstacleViews;
        public List<EnemyView> EnemyViews => _enemyViews;
    }
}
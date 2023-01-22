using System.Collections.Generic;
using Presentation.Map;
using Presentation.MapObjects.Obstacles;
using UnityEngine;
using Zenject.SpaceFighter;

namespace Presentation.Levels
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
using System.Collections.Generic;
using Presentation.MapObjects.Obstacles;
using UnityEngine;

namespace DomainModel.Configurations
{
    [CreateAssetMenu(fileName = "ObstacleConfigurations", menuName = "Configurations/ObstacleConfigurations")]
    public class ObstacleConfigurations : ScriptableObject
    {
        [SerializeField] private List<ObstacleView> _obstaclePrefabs;

        public int PrefabsCount => _obstaclePrefabs.Count;

        public ObstacleView GetObstaclePrefab(int index)
        {
            if (index < PrefabsCount)
            {
                return _obstaclePrefabs[index];
            }
            
            Debug.LogWarning("Index Is Larger Or Equal To Prefabs Count. Last Prefab Has Been Returned");
            return _obstaclePrefabs[PrefabsCount - 1];
        }
    }
}
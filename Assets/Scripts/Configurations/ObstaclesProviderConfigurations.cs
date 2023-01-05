using UnityEngine;

namespace Configurations
{
    [CreateAssetMenu(fileName = "ObstaclesProviderConfigurations", menuName = "Configurations/ObstaclesProviderConfigurations")]
    public class ObstaclesProviderConfigurations : ScriptableObject
    {
        [SerializeField] private int _maxObstaclesAmount;

        public int MaxObstaclesAmount => _maxObstaclesAmount;
    }
}
using UnityEngine;

namespace DomainModel.Configurations
{
    [CreateAssetMenu(fileName = "EnemiesProviderConfigurations", menuName = "Configurations/EnemiesProviderConfigurations")]
    public class EnemiesProviderConfigurations : ScriptableObject
    {
        [SerializeField] private int _maxEnemiesAmount;

        public int MaxEnemiesAmount => _maxEnemiesAmount;
    }
}
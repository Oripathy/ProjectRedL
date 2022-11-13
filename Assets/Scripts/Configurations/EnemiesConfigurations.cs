using UnityEngine;
using Zenject.SpaceFighter;

namespace Containers
{
    [CreateAssetMenu(fileName = "EnemiesConfigurations", menuName = "Configurations/EnemiesConfigurations")]
    public class EnemiesConfigurations : ScriptableObject
    {
        [SerializeField] private EnemyView _enemyPrefab;

        public EnemyView EnemyPrefab => _enemyPrefab;
    }
}
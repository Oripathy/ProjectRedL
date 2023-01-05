using System.Collections.Generic;
using Configurations;
using Map.MapCells.Implementation;
using Zenject;

namespace MapObjects.Enemies.Implementation
{
    public class EnemiesProvider
    {
        private readonly EnemiesProviderConfigurations _configurations;
        private readonly IFactory<Indices, EnemyModel> _factory;
        private readonly List<EnemyModel> _enemies;

        public EnemiesProvider(EnemiesProviderConfigurations configurations, IFactory<Indices, EnemyModel> factory)
        {
            _configurations = configurations;
            _factory = factory;
            _enemies = new List<EnemyModel>(_configurations.MaxEnemiesAmount);
        }

        public void SpawnEnemy(Indices indices)
        {
            var enemy = _factory.Create(indices);
            _enemies.Add(enemy);
        }
    }
}
using Configurations;
using UnityEngine;
using Zenject;

namespace Installers
{
    [CreateAssetMenu(fileName = "ConfigurationsInstaller", menuName = "Configurations/ConfigurationsInstaller")]
    public class ConfigurationsInstaller : ScriptableObjectInstaller<ConfigurationsInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<EnemiesConfigurations>()
                .FromNewScriptableObjectResource("Configurations/EnemiesConfigurations").AsSingle();
            Container.Bind<EnemiesProviderConfigurations>()
                .FromNewScriptableObjectResource("Configurations/EnemiesProviderConfigurations").AsSingle();
            Container.Bind<MapCellConfigurations>()
                .FromNewScriptableObjectResource("Configurations/MapCellConfigurations").AsSingle();
            Container.Bind<MapConfigurations>().FromNewScriptableObjectResource("Configurations/MapConfigurations")
                .AsSingle();
            Container.Bind<ObstacleConfigurations>()
                .FromNewScriptableObjectResource("Configurations/ObstacleConfigurations").AsSingle();
            Container.Bind<ObstaclesProviderConfigurations>()
                .FromNewScriptableObjectResource("Configurations/ObstaclesProviderConfigurations").AsSingle();
            Container.Bind<UnitConfigurations>().FromNewScriptableObjectResource("Configurations/UnitConfigurations")
                .AsSingle();
            Container.Bind<UnitsProviderConfigurations>()
                .FromNewScriptableObjectResource("Configurations/UnitsProviderConfigurations").AsSingle();
        }
    }
}
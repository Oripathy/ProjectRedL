using MapObjects.Enemies.Implementation;
using Zenject;

namespace MapObjects.Enemies
{
    public class EnemiesInstaller : Installer<EnemiesInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<EnemiesProvider>().AsSingle();
            Container.BindInterfacesAndSelfTo<EnemyFactory>().AsSingle();
        }
    }
}
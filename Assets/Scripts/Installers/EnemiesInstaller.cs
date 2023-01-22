using DomainModel.MapObjects.Enemies;
using Zenject;

namespace Installers
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
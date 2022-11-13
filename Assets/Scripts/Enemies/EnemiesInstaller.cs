using Enemies.Implementation;
using Enemies.Interfaces;
using Zenject;

namespace Enemies
{
    public class EnemiesInstaller : Installer<EnemiesInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<EnemyPresenter>().AsTransient();
            Container.BindInterfacesAndSelfTo<EnemyPool>().AsSingle();
            Container.BindIFactory<IEnemyFactory>().To<EnemyFactory>().AsSingle();
        }
    }
}
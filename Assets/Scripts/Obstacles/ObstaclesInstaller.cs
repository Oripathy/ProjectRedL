using Obstacles.Implementation;
using Obstacles.Interfaces;
using Zenject;

namespace Obstacles
{
    public class ObstaclesInstaller : Installer<ObstaclesInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<ObstaclePresenter>().AsTransient();
            Container.BindInterfacesAndSelfTo<ObstaclePool>().AsSingle();
            Container.BindIFactory<IObstacleFactory>().To<ObstacleFactory>().AsSingle();
        }
    }
}
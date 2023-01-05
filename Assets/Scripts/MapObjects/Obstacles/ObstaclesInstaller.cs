using MapObjects.Obstacles.Implementation;
using Zenject;

namespace MapObjects.Obstacles
{
    public class ObstaclesInstaller : Installer<ObstaclesInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ObstaclesPresenter>().AsSingle();
            Container.BindInterfacesAndSelfTo<ObstaclesProvider>().AsSingle();
            Container.BindInterfacesAndSelfTo<ObstacleFactory>().AsSingle();
            Container.BindInterfacesAndSelfTo<ObstacleViewFactory>().AsSingle();
        }
    }
}
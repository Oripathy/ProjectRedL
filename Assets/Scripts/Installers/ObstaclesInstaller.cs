using DomainModel.MapObjects.Obstacles;
using Presentation.MapObjects.Obstacles;
using Zenject;

namespace Installers
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
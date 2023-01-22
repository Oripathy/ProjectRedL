using DomainModel.Map;
using DomainModel.Map.Cells;
using Presentation.Map;
using Presentation.Map.Cells;
using Zenject;

namespace Installers
{
    public class MapInstaller : Installer<MapInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MapPresenter>().AsSingle();
            Container.BindInterfacesAndSelfTo<MapModel>().AsSingle();
            Container.BindInterfacesAndSelfTo<MapCellFactory>().AsSingle();
            Container.BindInterfacesAndSelfTo<MapCellViewFactory>().AsSingle();
        }
    }
}
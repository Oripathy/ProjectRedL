using Map.Implementation;
using Map.MapCells.Implementation;
using Zenject;

namespace Map
{
    public class MapInstaller : Installer<MapInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MapPresenter>().AsSingle();
            Container.BindInterfacesAndSelfTo<MapCellPool>().AsSingle();
            Container.BindInterfacesAndSelfTo<MapCellFactory>().AsSingle();
        }
    }
}
using Units.Implementation;
using Units.Interfaces;
using Zenject;

namespace Units
{
    public class UnitsInstaller : Installer<UnitsInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<UnitPresenter>().AsTransient();
            Container.BindInterfacesAndSelfTo<UnitPool>().AsSingle();
            Container.BindIFactory<IUnitFactory>().To<UnitFactory>().AsSingle();
        }
    }
}
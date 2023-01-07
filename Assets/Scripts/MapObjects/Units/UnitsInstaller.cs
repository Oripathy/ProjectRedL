using MapObjects.Units.Implementation;
using Zenject;

namespace MapObjects.Units
{
    public class UnitsInstaller : Installer<UnitsInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<UnitsProvider>().AsSingle();
            Container.BindInterfacesAndSelfTo<UnitModelFactory>().AsSingle();
        }
    }
}
using DomainModel.MapObjects.Units;
using Zenject;

namespace Installers
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
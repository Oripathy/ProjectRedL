using Enemies;
using Map;
using Obstacles;
using Units;
using Zenject;

namespace Installers
{
    public class AppInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            MapInstaller.Install(Container);
            UnitsInstaller.Install(Container);
            ObstaclesInstaller.Install(Container);
            EnemiesInstaller.Install(Container);
        }
    }
}
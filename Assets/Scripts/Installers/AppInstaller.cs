using MainStateMachine;
using Map;
using MapObjects.Enemies;
using MapObjects.Obstacles;
using MapObjects.Units;
using Zenject;

namespace Installers
{
    public class AppInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            UnitsInstaller.Install(Container);
            ObstaclesInstaller.Install(Container);
            EnemiesInstaller.Install(Container);
            MapInstaller.Install(Container);
            // MainStateMachineInstaller.Install(Container);
        }
    }
}
using MainStateMachine.States;
using Zenject;

namespace MainStateMachine
{
    public class MainStateMachineInstaller : Installer<MainStateMachineInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MainLoopStateMachine>().AsSingle();
            Container.BindInterfacesAndSelfTo<GameSessionState>().AsSingle();
            Container.BindInterfacesAndSelfTo<MainMenuState>().AsSingle();
        }
    }
}
using System;

namespace DomainModel.MainStateMachine.States
{
    public class MainMenuState
    {
        public event Action<SessionContext> SessionRequested; 

        public void Enter()
        {
            throw new NotImplementedException();
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }
    }
}
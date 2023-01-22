using System;
using DomainModel.MainStateMachine.States;
using Zenject;

namespace DomainModel.MainStateMachine
{
    public class MainLoopStateMachine : IInitializable, IDisposable
    {
        private readonly MainMenuState _mainMenuState;
        private readonly GameSessionState _gameSessionState;

        public MainLoopStateMachine(MainMenuState mainMenuState, GameSessionState gameSessionState)
        {
            _mainMenuState = mainMenuState;
            _gameSessionState = gameSessionState;
        }

        public void Initialize()
        {
            _mainMenuState.SessionRequested += OnSessionRequested;
        }

        private void OnSessionRequested(SessionContext context)
        {
            _gameSessionState.Enter(context);
        }

        private void OnSessionFinished(SessionResultContext context)
        {
            
        }

        public void Dispose()
        {
        }
    }
}
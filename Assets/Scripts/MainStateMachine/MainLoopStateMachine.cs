using System;
using MainStateMachine.States;
using Zenject;

namespace MainStateMachine
{
    public class MainLoopStateMachine
    {
        private readonly MainMenuState _mainMenuState;
        private readonly GameSessionState _gameSessionState;

        public MainLoopStateMachine(MainMenuState mainMenuState, GameSessionState gameSessionState)
        {
            _mainMenuState = mainMenuState;
            _gameSessionState = gameSessionState;
        }
    }
}
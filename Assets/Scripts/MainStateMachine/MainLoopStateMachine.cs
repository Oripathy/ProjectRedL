using System;
using MainStateMachine.States;
using Map.Implementation;
using Zenject;

namespace MainStateMachine
{
    public class MainLoopStateMachine : IInitializable, IDisposable
    {
        private readonly MainMenuState _mainMenuState;
        private readonly GameSessionState _gameSessionState;
        private readonly MapModel _mapModel;
        private readonly IState _currentState;

        public MainLoopStateMachine(MainMenuState mainMenuState, GameSessionState gameSessionState, MapModel mapModel)
        {
            _mainMenuState = mainMenuState;
            _gameSessionState = gameSessionState;
            _mapModel = mapModel;
        }

        public void Initialize()
        {
            _mapModel.SetupMap();
        }

        public void Dispose()
        {
            
        }
    }
}
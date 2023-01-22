using System;
using DomainModel.Levels;
using Presentation.Scenes;

namespace DomainModel.MainStateMachine.States
{
    public class GameSessionState
    {
        private readonly ISceneProvider _sceneProvider;

        public event Action<SessionResultContext> SessionFinished;
        
        public GameSessionState(ISceneProvider sceneProvider)
        {
            _sceneProvider = sceneProvider;
        }

        public async void Enter(SessionContext context)
        {
            await _sceneProvider.LoadSceneAsync(context.SceneName); // TODO move scene loading into state machine
            context.LevelData.LevelFinished += OnLevelFinished;
            context.LevelData.LevelFailed += OnLevelFailed;
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }

        private void OnLevelFinished(LevelData levelData)
        {
            levelData.LevelFinished -= OnLevelFinished;
            levelData.LevelFailed -= OnLevelFailed;
        }

        private void OnLevelFailed(LevelData levelData)
        {
            
        }
    }
}
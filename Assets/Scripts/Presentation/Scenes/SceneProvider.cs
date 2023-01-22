using System;
using Base;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Presentation.Scenes
{
    public class SceneProvider : AsynchronousObj, ISceneProvider
    {
        private readonly ZenjectSceneLoader _sceneLoader;

        public SceneProvider(ZenjectSceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }

        public async UniTask LoadSceneAsync(string sceneName)
        {
            try
            {
                await _sceneLoader.LoadSceneAsync(sceneName);
            }
            catch (OperationCanceledException e)
            {
                Debug.Log(e);
                throw;
            }
        }
    }
}
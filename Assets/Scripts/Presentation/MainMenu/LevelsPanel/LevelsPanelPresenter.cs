using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Presentation.MainMenu.LevelsPanel
{
    public class LevelsPanelPresenter : Presenter<LevelsPanelView>, ILevelsPanel
    {
        public async UniTask SetActive(bool isActive)
        {
            try
            {
                await View.SetActive(isActive, TokenSource.Token);
            }
            catch (OperationCanceledException e)
            {
                Debug.Log(e);
                throw;
            }
        }
    }
}
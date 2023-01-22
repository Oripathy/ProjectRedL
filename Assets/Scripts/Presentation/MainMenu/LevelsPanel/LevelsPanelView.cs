using System.Threading;
using Cysharp.Threading.Tasks;
using Presentation.Helpers;

namespace Presentation.MainMenu.LevelsPanel
{
    public class LevelsPanelView : View
    {
        public UniTask SetActive(bool isActive, CancellationToken token)
        {
            if (isActive)
            {
                return UIAnimations.SetActiveWithScale(transform, true, token);
            }
            
            gameObject.SetActive(false);
            return UniTask.CompletedTask;
        }
    }
}
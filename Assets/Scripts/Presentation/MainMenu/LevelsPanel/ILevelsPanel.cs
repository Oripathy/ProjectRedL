using Cysharp.Threading.Tasks;

namespace Presentation.MainMenu.LevelsPanel
{
    public interface ILevelsPanel
    {
        public UniTask SetActive(bool isActive);
    }
}
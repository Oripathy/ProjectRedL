using Cysharp.Threading.Tasks;

namespace Presentation.Scenes
{
    public interface ISceneProvider
    {
        public UniTask LoadSceneAsync(string sceneName);
    }
}
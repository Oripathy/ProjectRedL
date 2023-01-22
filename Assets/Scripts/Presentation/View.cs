using UnityEngine;

namespace Presentation
{
    public abstract class View : MonoBehaviour
    {
        public void SetActive(bool isActive)
        {
            gameObject.SetActive(isActive);
        }
    }
}

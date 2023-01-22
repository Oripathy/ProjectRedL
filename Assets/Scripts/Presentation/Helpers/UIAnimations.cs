using System.Threading;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Presentation.Helpers
{
    public static class UIAnimations
    {
        private const float ActivationDuration = 0.3f;
        private const float ActiveScaleMultiplier = 1f;
        private const float InactiveScaleMultiplier = 0.6f;

        public static UniTask SetActiveWithMovement(RectTransform obj, bool isActive, Vector2 activePosition,
            Vector2 inactivePosition, CancellationToken token, float activationDuration = ActivationDuration)
        {
            switch (isActive)
            {
                case true:
                    obj.anchoredPosition = inactivePosition;
                    return obj.DOAnchorPos(activePosition, activationDuration).WithCancellation(token);
                
                case false:
                    return obj.DOAnchorPos(inactivePosition, activationDuration).WithCancellation(token);
            }
        }

        public static UniTask SetActiveWithScale(Transform obj, bool isActive, CancellationToken token,
            float activationDuration = ActivationDuration, float activeScaleMultiplier = ActiveScaleMultiplier,
            float inactiveScaleMultiplier = InactiveScaleMultiplier)
        {
            switch (isActive)
            {
                case true:
                    obj.localScale = Vector3.one * inactiveScaleMultiplier;
                    return obj.DOScale(Vector3.one * activeScaleMultiplier, activationDuration).WithCancellation(token);
                
                case false:
                    return obj.DOScale(Vector3.one * inactiveScaleMultiplier, activationDuration)
                        .WithCancellation(token);
            }
        }
    }
}
using System;
using System.Threading;
using Base;
using Configurations;
using Cysharp.Threading.Tasks;
using MainCamera.Interfaces;
using MapObjects.Units.Implementation;
using UnityEngine;
using Zenject;

namespace Inputs
{
    public class InputProvider : AsynchronousObj, IInitializable, IDisposable
    {
        private readonly IMainCamera _mainCamera;
        private readonly InputConfigurations _configurations;
        private Vector2 _initialPosition;
        private Vector2 _swipeDelta;
        
        public bool IsInputHandling { get; set; }

        public event Action<Vector2> DirectionReceived;
        public event Action<UnitView> UnitLockStateChangeRequested;

        public InputProvider(IMainCamera mainCamera, InputConfigurations configurations)
        {
            _mainCamera = mainCamera;
            _configurations = configurations;
        }
        
        public void Initialize()
        {
            IsInputHandling = true;
            HandleInput(TokenSource.Token).Forget();
        }

        private async UniTask HandleInput(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                if (IsInputHandling)
                {
                    var direction = Vector3.zero;
                    if (Input.GetMouseButtonDown(0))
                    {
                        _initialPosition = Input.mousePosition;
                    }

                    if (Input.GetMouseButton(0))
                    {
                        _swipeDelta = (Vector2) Input.mousePosition - _initialPosition;
                        if (_swipeDelta.magnitude > _configurations.MinSwipeDelta)
                        {
                            var x = _swipeDelta.x;
                            var y = _swipeDelta.y;
                            direction = Mathf.Abs(x) > Mathf.Abs(y)
                                ? new Vector2(Mathf.Sign(x), 0f)
                                : new Vector2(0f, -Mathf.Sign(y));
                        }
                    }

                    if (Input.GetMouseButtonUp(0))
                    {
                        if (direction.magnitude > 0)
                        {
                            DirectionReceived?.Invoke(direction);
                        }
                        else
                        {
                            TryRaycastToUnitView();
                        }
                        
                        Reset();
                    }
                }

                await UniTask.Yield();
            }
        }

        private void TryRaycastToUnitView()
        {
            var ray = _mainCamera.MainCamera.ScreenPointToRay(Input.mousePosition);
            if (!Physics.Raycast(ray, out var hit, _configurations.UnitLayerMask))
            {
                return;
            }
            
            if (hit.collider.TryGetComponent<UnitView>(out var unitView))
            {
                UnitLockStateChangeRequested?.Invoke(unitView);
            }
        }

        private void Reset()
        {
            _initialPosition = Vector2.zero;
            _swipeDelta = Vector2.zero;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
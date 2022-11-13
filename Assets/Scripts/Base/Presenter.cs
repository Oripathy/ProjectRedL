using System;
using System.Threading;
using UnityEngine;

namespace Base
{
    public abstract class Presenter<TView>
        where TView : View
    {
        private TView _view;
        private CancellationTokenSource _tokenSource;

        protected TView View => _view;
        protected CancellationTokenSource TokenSource => _tokenSource;

        public virtual void Initialize()
        {
            
        }
        
        public virtual void SetView(TView view)
        {
            
        }

        protected CancellationTokenSource CreateCancellationTokenSource()
        {
            if (_tokenSource != null)
            {
                throw new InvalidOperationException(
                    "Token Source Is Not Null. Call Dispose Token Source Before Creating A New One");
            }

            return _tokenSource = new CancellationTokenSource();
        }

        protected void DisposeTokenSource()
        {
            _tokenSource?.Cancel();
            _tokenSource?.Dispose();
            _tokenSource = null;
        }

        public virtual void Dispose()
        {
            DisposeTokenSource();
        }
    }
}
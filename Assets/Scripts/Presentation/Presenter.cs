using System;
using Base;
using Zenject;

namespace Presentation
{
    public abstract class Presenter<TView> : AsynchronousObj, IInitializable, IDisposable
        where TView : View
    {
        private TView _view;

        protected TView View => _view;

        public virtual void Initialize()
        {
            
        }

        public virtual void SetView(TView view)
        {
            _view = view;
        }

        public virtual void Dispose()
        {
            DisposeTokenSource();
        }
    }
}
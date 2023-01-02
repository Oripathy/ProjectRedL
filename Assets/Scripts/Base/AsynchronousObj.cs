using System.Threading;

namespace Base
{
    public class AsynchronousObj
    {
        private CancellationTokenSource _tokenSource;

        protected CancellationTokenSource TokenSource => _tokenSource ??= new CancellationTokenSource();

        protected void DisposeTokenSource()
        {
            _tokenSource?.Cancel();
            _tokenSource?.Dispose();
            _tokenSource = default;
        }
    }
}
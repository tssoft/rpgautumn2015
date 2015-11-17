
namespace Euler
{
    internal abstract class AbstractEulerTask : IEulerTask
    {
        private string result;
        
        protected abstract string Title { get; }

        public abstract void Solve();

        public string Result 
        { 
            get 
            { 
                return result; 
            } 
        }
    }
}

using Adapter.Interfaces;

namespace Adapter
{
    public class Client
    {
        public void Request(ITargetRequest target)
        {
            target.TargetRequest();
        }
    }
}
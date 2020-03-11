using Adapter.Model;

namespace Adapter
{
    public class Adapter : Target
    {
        private readonly Adaptable _adaptable = new Adaptable();

        public override void TargetRequest()
        {
            _adaptable.AdaptableRequest();
        }
    }
}
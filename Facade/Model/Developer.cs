using Facade.Facades;

namespace Facade.Model
{
    public class Developer
    {
        public void CreateApplication(RiderFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
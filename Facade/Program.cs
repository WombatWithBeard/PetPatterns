using Facade.Facades;
using Facade.Model;

namespace Facade
{
    class Program
    {
        static void Main()
        {
            var ide = new RiderFacade(new TextEditor(), new Compiler(), new CLR());
            var developer = new Developer();
            
            developer.CreateApplication(ide);
        }
    }
}
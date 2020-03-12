using Facade.Facades;
using Facade.Model;

namespace Facade
{
    internal class Program
    {
        private static void Main()
        {
            var ide = new RiderFacade(new TextEditor(), new Compiler(), new CLR());
            var developer = new Developer();
            
            developer.CreateApplication(ide);
        }
    }
}
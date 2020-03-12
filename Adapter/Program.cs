using Adapter.Model;

namespace Adapter
{
    internal class Program
    {
        private static void Main()
        {
            var c = new Client();
            c.Request(new Target());
            c.Request(new Adapter());
        }
    }
}
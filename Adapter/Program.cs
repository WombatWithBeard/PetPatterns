using Adapter.Model;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            var c = new Client();
            c.Request(new Target());
            c.Request(new Adapter());
        }
    }
}
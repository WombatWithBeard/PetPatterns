using Adapter.Model;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Client();
            c.Request(new Target());
            c.Request(new Adapter());
        }
    }
}
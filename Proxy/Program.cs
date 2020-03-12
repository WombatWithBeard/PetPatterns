using System;
using Proxy.Interfaces;
using Proxy.Proxys;

namespace Proxy
{
    class Program
    {
        static void Main()
        {
            using IBook book = new BookStoreProxy();
            
            var page1 = book.GetPage(1);
            Console.WriteLine(page1.Text);

            var page2 = book.GetPage(2);
            Console.WriteLine(page2.Text);

            page1 = book.GetPage(1);
            Console.WriteLine(page1.Text);
        }
    }
}
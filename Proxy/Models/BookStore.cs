using System.Linq;
using Microsoft.EntityFrameworkCore;
using Proxy.Contexts;
using Proxy.Interfaces;

namespace Proxy.Models
{
    public class BookStore : IBook
    {
        private readonly PageContext _pageContext;

        public BookStore()
        {
            _pageContext = new PageContext();
        }

        public void Dispose()
        {
            _pageContext.Dispose();
        }

        public Page GetPage(int number)
        {
            return _pageContext.Pages.FirstOrDefault(p => p.Number == number);
        }
    }
}
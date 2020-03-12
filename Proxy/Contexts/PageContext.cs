using Microsoft.EntityFrameworkCore;
using Proxy.Models;

namespace Proxy.Contexts
{
    public class PageContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
    }
}
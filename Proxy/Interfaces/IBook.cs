using System;
using Proxy.Models;

namespace Proxy.Interfaces
{
    public interface IBook : IDisposable
    {
        Page GetPage(int number);
    }
}
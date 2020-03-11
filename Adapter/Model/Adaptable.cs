using System;
using Adapter.Interfaces;

namespace Adapter.Model
{
    public class Adaptable : IAdaptableRequest
    {
        public void AdaptableRequest()
        {
            Console.WriteLine("From adaptable");
        }
    }
}
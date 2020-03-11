using System;
using Adapter.Interfaces;

namespace Adapter.Model
{
    public class Target : ITargetRequest
    {
        public virtual void TargetRequest()
        {
            Console.WriteLine("From Target");
        }
    }
}
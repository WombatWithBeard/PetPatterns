using System;

namespace Composite.Models
{
    public abstract class Component
    {
        protected readonly string Name;

        protected Component(string name)
        {
            Name = name;
        }

        public virtual void Add(Component component){}
        
        public virtual void Remove(Component component){}

        public virtual void Print() => Console.WriteLine(Name);
    }
}
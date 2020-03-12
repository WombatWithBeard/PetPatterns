using System;
using System.Collections.Generic;

namespace Composite.Models
{
    public class Directory : Component
    {
        private readonly List<Component> _components;

        public Directory(string name) : base(name)
        {
            _components = new List<Component>();
        }

        public override void Add(Component component)
        {
            _components.Add(component);
        }

        public override void Remove(Component component)
        {
            _components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine("Directory: " + Name);
            Console.WriteLine("Folders: ");
            _components.ForEach(c => c.Print());
        }
    }
}
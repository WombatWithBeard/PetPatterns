using System;
using Bridge.Interfaces;

namespace Bridge.Models
{
    public class CSharpLanguage : ILanguage
    {
        public void Build()
        {
            Console.WriteLine("C# build");
        }

        public void Execute()
        {
            Console.WriteLine("Start c# application");
        }
    }
}
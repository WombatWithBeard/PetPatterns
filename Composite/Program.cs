using System;
using Composite.Models;

namespace Composite
{
    internal class Program
    {
        private static void Main()
        {
            var fileSystem = new Directory("File system");
            var diskC = new Directory("Disk C");
            var pngFile = new File("1234.png");
            var docFile = new File("Doc.doc");
            
            var newFolder = new Directory("New folder");
            var txtFile = new File("text.txt");
            var csFile = new File("Program.cs");
            
            diskC.Add(pngFile);
            diskC.Add(docFile);
            fileSystem.Add(diskC);
            
            fileSystem.Print();
            Console.WriteLine("-----------------------");
            
            fileSystem.Remove(pngFile);
            
            newFolder.Add(txtFile);
            newFolder.Add(csFile);
            diskC.Add(newFolder);
            
            fileSystem.Print();
        }
    }
}
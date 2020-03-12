using Visitor.Models;
using Visitor.Visitors;

namespace Visitor
{
    internal class Program
    {
        private static void Main()
        {
            var structure = new Structure();
            
            structure.Add(new Person{Name = "TestPerson", Number = "123456"});
            structure.Add(new Company{Name = "TestCompany", Number = "09876", RegNumber = "123098"});
            structure.Add(new Company{Name = "TestCompany2", Number = "1209876", RegNumber = "12123098"});
            
            structure.Accept(new DictionaryVisitor());
            structure.Accept(new ListVisitor());
        }
    }
}
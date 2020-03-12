using System;
using System.Collections.Generic;
using Visitor.Interfaces;
using Visitor.Models;

namespace Visitor.Visitors
{
    public class DictionaryVisitor : IVisitor
    {
        public void VisitPerson(Person person)
        {
            var result = new Dictionary<string, string> {{person.Name, person.Number}};

            foreach (var (key, value) in result)
            {
                Console.WriteLine($"Dict: Person name is {key}; Person number is {value}");
            }
        }

        public void VisitCompany(Company company)
        {
            var result = new Dictionary<string, object> {{company.RegNumber, new {company.Name, company.Number}}};

            foreach (var (key, value) in result)
            {
                Console.WriteLine($"Dict: Company id is {key}; Company data is {value}");
            }
        }
    }
}
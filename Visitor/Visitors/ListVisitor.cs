using System;
using System.Collections.Generic;
using Visitor.Interfaces;
using Visitor.Models;

namespace Visitor.Visitors
{
    public class ListVisitor : IVisitor
    {
        public void VisitPerson(Person person)
        {
            var result = new List<string> {$"List: Person name is {person.Name}; Person number is {person.Number}"};

            result.ForEach(Console.WriteLine);
        }

        public void VisitCompany(Company company)
        {
            var result = new List<string>
            {
                $"List: Company name is {company.Name}; Company number is {company.Number}; Company reg number is {company.RegNumber}"
            };

            result.ForEach(Console.WriteLine);
        }
    }
}
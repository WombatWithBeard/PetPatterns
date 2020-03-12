using Visitor.Models;

namespace Visitor.Interfaces
{
    public interface IVisitor
    {
        void VisitPerson(Person person);
        void VisitCompany(Company company);
    }
}
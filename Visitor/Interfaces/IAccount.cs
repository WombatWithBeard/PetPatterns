namespace Visitor.Interfaces
{
    public interface IAccount
    {
        void Accept(IVisitor visitor);
    }
}
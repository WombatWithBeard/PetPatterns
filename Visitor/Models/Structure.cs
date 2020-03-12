using System.Collections.Generic;
using Visitor.Interfaces;

namespace Visitor.Models
{
    public class Structure
    {
        private readonly List<IAccount> _accounts;

        public Structure()
        {
            _accounts = new List<IAccount>();
        }

        public void Add(IAccount account) => _accounts.Add(account);

        public void Remove(IAccount account) => _accounts.Remove(account);

        public void Accept(IVisitor visitor) => _accounts.ForEach(a => a.Accept(visitor));
    }
}
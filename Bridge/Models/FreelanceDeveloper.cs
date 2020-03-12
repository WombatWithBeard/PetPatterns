using System;
using Bridge.Interfaces;

namespace Bridge.Models
{
    public class FreelanceDeveloper : Developer
    {
        public FreelanceDeveloper(ILanguage language) : base(language)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Get money after task complete");
        }
    }
}
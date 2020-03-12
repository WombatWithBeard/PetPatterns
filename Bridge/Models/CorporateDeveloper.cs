using System;
using Bridge.Interfaces;

namespace Bridge.Models
{
    public class CorporateDeveloper : Developer
    {
        public CorporateDeveloper(ILanguage language) : base(language)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Get money in the end on the month");
        }
    }
}
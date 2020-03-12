using Bridge.Models;

namespace Bridge
{
    internal class Program
    {
        private static void Main()
        {
            var freelancer = new FreelanceDeveloper(new CppLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();
            
            freelancer.Language = new CSharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();
            
            var corporate = new CorporateDeveloper(new CSharpLanguage());
            corporate.DoWork();
            freelancer.EarnMoney();
        }
    }
}
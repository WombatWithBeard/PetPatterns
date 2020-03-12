using Bridge.Interfaces;

namespace Bridge.Models
{
    public abstract class Developer
    {
        protected Developer(ILanguage language)
        {
            Language = language;
        }

        public ILanguage Language { get; set; }

        public virtual void DoWork()
        {
            Language.Build();
            Language.Execute();
        }

        public abstract void EarnMoney();
    }
}
using System;

namespace AbstractFactory.Models.Default
{
    public class Wall : BaseRoom
    {
        public override void Enter()
        {
            Console.WriteLine("Вы бьетесь головой о стену");
        }
    }
}
using System;
using SeaBattleLibrary;

namespace SeaBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Морской бой";
            var User = new User();
            var Bot = new Bot();
            Boolean yes = true;
            while (yes)
            {
                while (true)
                {
                    User.Output(User.BattleField);
                    User.Strike();
                    if (User.Win())
                    {
                        break;
                    }
                }
                Console.SetCursorPosition(30, 1);
                Console.WriteLine("Спасибо за игру!");
            }
        }
    }
}
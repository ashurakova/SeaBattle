using System;
using SeaBattleLibrary;

namespace SeaBattle
{
    public class Program
    {
        static void Main(string[] args)
        {   
            Console.Title = "Морской бой";
            FourDeskShip FourDeskShip = new FourDeskShip();
            ThreeDeskShip ThreeDeskShips = new ThreeDeskShip();
            TwoDeskShip TwoDeskShips = new TwoDeskShip();
            OneDeskShip OneDeskShips = new OneDeskShip();
            User user = new User();
            Boolean GameFinished = false;
            while (GameFinished!=true)
            {   
                BattleShip.Output(BattleShip.BattleField);
                if (UserWinValidation.Win() == true)
                {
                    GameFinished = true;
                    break;
                }
                user.StepMaking();
            }
            Console.SetCursorPosition(30, 1);
            Console.WriteLine("Спасибо за игру!");
        }
    }
}
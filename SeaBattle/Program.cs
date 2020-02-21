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
            FourDeskShip.ShipPlacement(1);
            ThreeDeskShip ThreeDeskShip = new ThreeDeskShip();
            ThreeDeskShip.ShipPlacement(2);
            TwoDeskShip TwoDeskShip = new TwoDeskShip();
            TwoDeskShip.ShipPlacement(3);
            OneDeskShip OneDeskShip = new OneDeskShip();
            OneDeskShip.ShipPlacement(4);
            User user = new User();
            Boolean GameFinished = false;
            while (GameFinished != true)
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
            Console.ReadKey();
        }
    }
}
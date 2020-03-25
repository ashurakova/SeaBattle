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
            ShipPlacementValidation.FullShipsPlacementValidation(BattleShip.BotField);
            User user = new User();
            bool IsGameFinished = false;
            while (!IsGameFinished)
            {
                BattleShip.Output(BattleShip.BattleField);
                if (UserWinValidation.Win())
                {
                    Console.Clear();
                    BattleShip.Output(BattleShip.BattleField);
                    Console.SetCursorPosition(30, 0);
                    Console.WriteLine($"Вы победили, сделав {User.Step} шагов!");
                    Console.SetCursorPosition(30, 1);
                    Console.WriteLine("Спасибо за игру!");
                    IsGameFinished = true;
                    break;
                }
                user.StepMaking();
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBattleLibrary
{
    public class FourDeskShip:Ship
    {
        public FourDeskShip()
        {
            while (NumberOfShip < 1)
            {
                ShipPlacement();
            }
        }

        int NumberOfShip = 0;
        public override void ShipPlacement()
        {
            var random = new Random();
            int x = random.Next(0, 9);
            int y = random.Next(0, 9);
            if (y > 5)
            {
                for (int i = y; i > y - 4; i--)
                {
                    BattleShip.BotField[i, x] = 1;
                    NumberOfShip++;
                }
            }
            else
            {
                for (int i = y; i < y + 4; i++)
                {
                    BattleShip.BotField[i, x] = 1;
                    NumberOfShip++;
                }
            }

        }
    }
}
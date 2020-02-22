using System;
using System.Collections;

namespace SeaBattleLibrary
{
    public class TwoDeskShip : Ship
    {
        ShipPlacementValidation TwoDeskShipValidation = new ShipPlacementValidation();
        public override void ShipPlacement(int n)
        {
            int q = 0;
            while (q < n)
            {
                var random = new Random();
                int x = random.Next(0, 9);
                int y = random.Next(0, 9);
                ArrayList Coordinates = new ArrayList();
                bool ShipCreation;
                if (y > 5)
                {
                    for (int i = y; i > y - 2; i--)
                    {
                        Coordinates.Add(i);
                    }
                    ShipCreation = TwoDeskShipValidation.ShipValidation(Coordinates, x);
                    if (ShipCreation == true)
                    {
                        for (int i = y; i > y - 2; i--)
                        {
                            BattleShip.BotField[i, x] = 1;
                        }
                        q++;
                    }
                }
                else if (y <= 5)
                {
                    for (int i = y; i < y + 2; i++)
                    {
                        Coordinates.Add(i);
                    }
                    ShipCreation = TwoDeskShipValidation.ShipValidation(Coordinates, x);
                    if (ShipCreation == true)
                    {
                        for (int i = y; i < y + 2; i++)
                        {
                            BattleShip.BotField[i, x] = 1;
                        }
                        q++;
                    }
                }
            }
        }
    }
}
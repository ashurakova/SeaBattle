using System;
using System.Collections;

namespace SeaBattleLibrary
{
    public class ThreeDeskShip : Ship
    {
        ShipPlacementValidation ThreeDeskShipValidation = new ShipPlacementValidation();
        public override void ShipPlacement(int ShipsToPlace)
        {
            int PlacedShips = 0;
            while (PlacedShips < ShipsToPlace)
            {
                var random = new Random();
                int x = random.Next(0, 10);
                int y = random.Next(0, 10);
                ArrayList Coordinates = new ArrayList();
                if (y > 5)
                {
                    for (int i = y; i > y - 3; i--)
                    {
                        Coordinates.Add(i);
                    }
                    if (ThreeDeskShipValidation.ShipValidation(Coordinates, x))
                    {
                        for (int i = y; i > y - 3; i--)
                        {
                            BattleShip.BotField[i, x] = Cells.Ship;
                        }
                        PlacedShips++;
                    }
                }
                else if (y <= 5)
                {
                    for (int i = y; i < y + 3; i++)
                    {
                        Coordinates.Add(i);
                    }
                    if (ThreeDeskShipValidation.ShipValidation(Coordinates, x))
                    {
                        for (int i = y; i < y + 3; i++)
                        {
                            BattleShip.BotField[i, x] = Cells.Ship;
                        }
                        PlacedShips++;
                    }
                }
            }
        }
    }
}
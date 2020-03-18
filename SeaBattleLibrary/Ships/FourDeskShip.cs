using System;

namespace SeaBattleLibrary
{
    public class FourDeskShip : Ship
    {
        public override void ShipPlacement(int ShipsToPlace)
        {
            int PlacedShips = 0;
            while (PlacedShips < ShipsToPlace)
            {
                var random = new Random();
                int x = random.Next(0, 10);
                int y = random.Next(0, 10);
                if (y > 5)
                {
                    for (int i = y; i > y - 4; i--)
                    {
                        BattleShip.BotField[i, x] = Cells.Ship;
                        PlacedShips++;
                    }
                }
                else
                {
                    for (int i = y; i < y + 4; i++)
                    {
                        BattleShip.BotField[i, x] = Cells.Ship;
                        PlacedShips++;
                    }
                }
            }
        }
    }
}
using System;

namespace SeaBattleLibrary
{
    public class FourDeskShip : Ship
    {
        public override void ShipPlacement(int n)
        {
            int q = 0;
            while (q < n)
            {
                var random = new Random();
                int x = random.Next(0, 10);
                int y = random.Next(0, 10);
                if (y > 5)
                {
                    for (int i = y; i > y - 4; i--)
                    {
                        BattleShip.BotField[i, x] = 1;
                        q++;
                    }
                }
                else
                {
                    for (int i = y; i < y + 4; i++)
                    {
                        BattleShip.BotField[i, x] = 1;
                        q++;
                    }
                }
            }
        }
    }
}
using System;
using System.Collections;

namespace SeaBattleLibrary
{
    public class OneDeskShip : Ship
    {
        ShipPlacementValidation OneDeskShipValidation = new ShipPlacementValidation();
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
                Coordinates.Add(y);
                ShipCreation = OneDeskShipValidation.ShipValidation(Coordinates, x);
                if (ShipCreation == true)
                {
                    BattleShip.BotField[y, x] = 1;
                    q++;
                }
            }
        }
    }
}
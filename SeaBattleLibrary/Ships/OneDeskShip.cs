using System;
using System.Collections;

namespace SeaBattleLibrary
{
    public class OneDeskShip:Ship
    {
        public OneDeskShip()
        {
            while (NumberOfShip < 4)
            {
                ShipPlacement();
            }
        }
        int NumberOfShip = 0;
        ShipPlacementValidation OneDeskShipValidation = new ShipPlacementValidation();
        public override void ShipPlacement()
        {
            var random = new Random();
            int x = random.Next(0, 9);
            int y = random.Next(0, 9);

            ArrayList Coordinates = new ArrayList();
            bool ShipCreation;
            Coordinates.Add(y);
            ShipCreation = OneDeskShipValidation.ShipValidation(Coordinates, x, BattleShip.BotField);
            if (ShipCreation == true)
            {
                BattleShip.BotField[y, x] = 1;
                NumberOfShip++;
            }
        }
    }
}
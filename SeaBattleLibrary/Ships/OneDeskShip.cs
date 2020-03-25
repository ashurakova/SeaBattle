using System;
using System.Collections;

namespace SeaBattleLibrary
{
    public class OneDeskShip : Ship
    {
        ShipPlacementValidation OneDeskShipValidation = new ShipPlacementValidation();
        public override void ShipPlacement(int shipsToPlace)
        {
            int PlacedShips = 0;
            while (PlacedShips < shipsToPlace)
            {
                var random = new Random();
                int x = random.Next(0, 10);
                int y = random.Next(0, 10);
                ArrayList Coordinates = new ArrayList();
                Coordinates.Add(y);
                if (OneDeskShipValidation.ShipValidation(Coordinates, x))
                {
                    BattleShip.BotField[y, x] = Cells.Ship;
                    PlacedShips++;
                }
            }
        }
    }
}
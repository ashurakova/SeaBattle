using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SeaBattleLibrary
{
    public class ThreeDeskShip:Ship
    { 
        public ThreeDeskShip ()
        {
            while (NumberOfShip<2)
            {
                ShipPlacement();
            }
        }
        
        int NumberOfShip = 0;
        ShipPlacementValidation ThreeDeskShipValidation = new ShipPlacementValidation();
       
        public override void ShipPlacement()
        {
            var random = new Random();
            int x = random.Next(0, 9);
            int y = random.Next(0, 9);
            ArrayList Coordinates = new ArrayList();
            bool ShipCreation;
            if (y > 5)
            {
                for (int i = y; i > y - 3; i--)
                {
                    Coordinates.Add(i);
                }
                ShipCreation = ThreeDeskShipValidation.ShipValidation(Coordinates, x, BattleShip.BotField);
                if (ShipCreation == true)
                {
                    for (int i = y; i > y - 3; i--)
                    {
                        BattleShip.BotField[i, x] = 1;
                    }
                    NumberOfShip++;
                }
            }
            else if (y <= 5)
            {
                for (int i = y; i > y + 3; i++)
                {
                    Coordinates.Add(i);

                }
                ShipCreation = ThreeDeskShipValidation.ShipValidation(Coordinates, x, BattleShip.BotField);
                if (ShipCreation == true)
                {
                    for (int i = y; i < y + 3; i++)
                    {
                        BattleShip.BotField[i, x] = 1;
                    }
                    NumberOfShip++;
                }
            }   
        }
    }
}
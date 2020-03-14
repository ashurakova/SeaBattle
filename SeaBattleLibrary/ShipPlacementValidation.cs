using System;
using System.Collections;

namespace SeaBattleLibrary
{
    public class ShipPlacementValidation
    {
        public bool ShipValidation(ArrayList cells, int x)
        {
            int counter=0;

            foreach (int i in cells)
            {
                if (BattleShip.BotField[i, x] == Cells.Ship)
                {
                    counter++;
                }
                else if (i == 0)
                {
                    if (x == 0)
                    {
                        if (BattleShip.BotField[i + 1, x] == Cells.Ship || BattleShip.BotField[i, x + 1] == Cells.Ship || BattleShip.BotField[i + 1, x + 1] == Cells.Ship)
                        {
                            counter++;
                        }
                    }
                    else if (x == 9)
                    {
                        if (BattleShip.BotField[i + 1, x] == Cells.Ship || BattleShip.BotField[i, x - 1] == Cells.Ship || BattleShip.BotField[i + 1, x - 1] == Cells.Ship)
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        if (BattleShip.BotField[i, x - 1] == Cells.Ship || BattleShip.BotField[i, x + 1] == Cells.Ship || BattleShip.BotField[i + 1, x] == Cells.Ship || BattleShip.BotField[i + 1, x + 1] == Cells.Ship || BattleShip.BotField[i + 1, x - 1] == Cells.Ship)
                        {
                            counter++;
                        }
                    }
                }
                else if (i == 9)
                {
                    if (x == 0)
                    {
                        if (BattleShip.BotField[i - 1, x] == Cells.Ship || BattleShip.BotField[i - 1, x + 1] == Cells.Ship || BattleShip.BotField[i, x + 1] == Cells.Ship)
                        {
                            counter++;
                        }
                    }
                    else if (x == 9)
                    {
                        if (BattleShip.BotField[i - 1, x] == Cells.Ship || BattleShip.BotField[i, x - 1] == Cells.Ship || BattleShip.BotField[i - 1, x - 1] == Cells.Ship)
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        if (BattleShip.BotField[i, x - 1] == Cells.Ship || BattleShip.BotField[i, x + 1] == Cells.Ship || BattleShip.BotField[i - 1, x] == Cells.Ship || BattleShip.BotField[i - 1, x - 1] == Cells.Ship || BattleShip.BotField[i - 1, x + 1] == Cells.Ship)
                        {
                            counter++;
                        }
                    }
                }
                else
                {
                    if (x == 0)
                    {
                        if (BattleShip.BotField[i - 1, x] == Cells.Ship || BattleShip.BotField[i + 1, x] == Cells.Ship || BattleShip.BotField[i, x + 1] == Cells.Ship || BattleShip.BotField[i - 1, x + 1] == Cells.Ship || BattleShip.BotField[i + 1, x + 1] == Cells.Ship)
                        {
                            counter++;
                        }
                    }
                    else if (x == 9)
                    {
                        if (BattleShip.BotField[i, x - 1] == Cells.Ship || BattleShip.BotField[i - 1, x] == Cells.Ship || BattleShip.BotField[i + 1, x] == Cells.Ship || BattleShip.BotField[i - 1, x - 1] == Cells.Ship || BattleShip.BotField[i + 1, x - 1] == Cells.Ship)
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        if (BattleShip.BotField[i, x - 1] == Cells.Ship || BattleShip.BotField[i - 1, x] == Cells.Ship || BattleShip.BotField[i + 1, x] == Cells.Ship || BattleShip.BotField[i - 1, x - 1] == Cells.Ship ||
                            BattleShip.BotField[i + 1, x - 1] == Cells.Ship || BattleShip.BotField[i, x + 1] == Cells.Ship || BattleShip.BotField[i + 1, x + 1] == Cells.Ship || BattleShip.BotField[i - 1, x + 1] == Cells.Ship)
                        {
                            counter++;
                        }

                    }
                }
            }
            if (counter == 0)
            return true; 
            else
            return false; 
        }

        public static void FullShipsPlacementValidation (int [,] Field)
        {
            int ShipCount = 0;
            foreach (int element in BattleShip.BotField)
            {
                if (element == 1)
                {
                    ShipCount++;
                }
            }
            if (ShipCount != 20)
            {
                throw new Exception("Недостаточное количество кораблей для начала игры.");
            }
        }
    }
}
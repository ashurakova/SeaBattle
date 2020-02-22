using System.Collections;

namespace SeaBattleLibrary
{
    public class ShipPlacementValidation
    {
        public bool ShipValidation(ArrayList list, int x)
        {
            int counter=0;

            foreach (int i in list)
            {
                if (BattleShip.BotField[i, x] == 1)
                {
                    counter++;
                }
                else if (i == 0)
                {
                    if (x == 0)
                    {
                        if (BattleShip.BotField[i + 1, x] == 1 || BattleShip.BotField[i, x + 1] == 1 || BattleShip.BotField[i + 1, x + 1] == 1)
                        {
                            counter++;
                        }
                    }
                    else if (x == 9)
                    {
                        if (BattleShip.BotField[i + 1, x] == 1 || BattleShip.BotField[i, x - 1] == 1 || BattleShip.BotField[i + 1, x - 1] == 1)
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        if (BattleShip.BotField[i, x - 1] == 1 || BattleShip.BotField[i, x + 1] == 1 || BattleShip.BotField[i + 1, x] == 1 || BattleShip.BotField[i + 1, x + 1] == 1 || BattleShip.BotField[i + 1, x - 1] == 1)
                        {
                            counter++;
                        }
                    }
                }
                else if (i == 9)
                {
                    if (x == 0)
                    {
                        if (BattleShip.BotField[i - 1, x] == 1 || BattleShip.BotField[i - 1, x + 1] == 1 || BattleShip.BotField[i, x + 1] == 1)
                        {
                            counter++;
                        }
                    }
                    else if (x == 9)
                    {
                        if (BattleShip.BotField[i - 1, x] == 1 || BattleShip.BotField[i, x - 1] == 1 || BattleShip.BotField[i - 1, x - 1] == 1)
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        if (BattleShip.BotField[i, x - 1] == 1 || BattleShip.BotField[i, x + 1] == 1 || BattleShip.BotField[i - 1, x] == 1 || BattleShip.BotField[i - 1, x - 1] == 1 || BattleShip.BotField[i - 1, x + 1] == 1)
                        {
                            counter++;
                        }
                    }
                }
                else
                {
                    if (x == 0)
                    {
                        if (BattleShip.BotField[i - 1, x] == 1 || BattleShip.BotField[i + 1, x] == 1 || BattleShip.BotField[i, x + 1] == 1 || BattleShip.BotField[i - 1, x + 1] == 1 || BattleShip.BotField[i + 1, x + 1] == 1)
                        {
                            counter++;
                        }
                    }
                    else if (x == 9)
                    {
                        if (BattleShip.BotField[i, x - 1] == 1 || BattleShip.BotField[i - 1, x] == 1 || BattleShip.BotField[i + 1, x] == 1 || BattleShip.BotField[i - 1, x - 1] == 1 || BattleShip.BotField[i + 1, x - 1] == 1)
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        if (BattleShip.BotField[i, x - 1] == 1 || BattleShip.BotField[i - 1, x] == 1 || BattleShip.BotField[i + 1, x] == 1 || BattleShip.BotField[i - 1, x - 1] == 1 ||
                            BattleShip.BotField[i + 1, x - 1] == 1 || BattleShip.BotField[i, x + 1] == 1 || BattleShip.BotField[i + 1, x + 1] == 1 || BattleShip.BotField[i - 1, x + 1] == 1)
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
    }
}
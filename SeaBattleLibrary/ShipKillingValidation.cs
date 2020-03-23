namespace SeaBattleLibrary
{
    public class ShipKillingValidation
    {
        public static void ShipKilling(int index, int letter)
        {
            if (index == 0)
            {
                if (BattleShip.BotField[index + 1, letter] != Cells.Ship)
                {
                    if (BattleShip.BotField[index + 1, letter] == Cells.Untouched)
                    {
                        if (letter == 0)
                        {
                            BattleShip.BattleField[index + 1, letter + 1] = Cells.Miss;
                            BattleShip.BattleField[index + 1, letter] = Cells.Miss;
                            BattleShip.BattleField[index, letter + 1] = Cells.Miss;
                        }
                        else if (letter == 9)
                        {

                            BattleShip.BattleField[index + 1, letter - 1] = Cells.Miss;

                            BattleShip.BattleField[index + 1, letter] = Cells.Miss;
                            BattleShip.BattleField[index, letter - 1] = Cells.Miss;
                        }
                        else
                        {
                            BattleShip.BattleField[index + 1, letter + 1] = Cells.Miss;
                            BattleShip.BattleField[index + 1, letter] = Cells.Miss;
                            BattleShip.BattleField[index, letter + 1] = Cells.Miss;
                            BattleShip.BattleField[index + 1, letter - 1] = Cells.Miss;
                            BattleShip.BattleField[index, letter - 1] = Cells.Miss;
                        }
                    }
                    else if (BattleShip.BotField[index + 1, letter] == Cells.Hit)
                    {
                        int cell = 1;
                        while (BattleShip.BotField[index + cell, letter] == Cells.Hit)
                        {
                            cell++;
                        }
                        if (BattleShip.BotField[index + cell, letter] != Cells.Ship)
                        {
                            if (letter == 0)
                            {
                                BattleShip.BattleField[index + cell, letter] = Cells.Miss;
                                for (; cell >= index; cell--)
                                {
                                    BattleShip.BattleField[index + cell, letter + 1] = Cells.Miss;
                                }
                            }
                            else if (letter == 9)
                            {
                                BattleShip.BattleField[index + cell, letter] = Cells.Miss;
                                for (; cell >= index; cell--)
                                {
                                    BattleShip.BattleField[index + cell, letter - 1] = Cells.Miss;
                                }
                            }
                            else
                            {
                                BattleShip.BattleField[index + cell, letter] = Cells.Miss;
                                for (; cell >= index; cell--)
                                {
                                    BattleShip.BattleField[index + cell, letter - 1] = Cells.Miss;
                                    BattleShip.BattleField[index + cell, letter + 1] = Cells.Miss;
                                }
                            }
                        }
                    }
                }
            }
            else if (index == 9)
            {
                if (BattleShip.BotField[index - 1, letter] != Cells.Ship)
                {
                    if (BattleShip.BotField[index - 1, letter] == Cells.Untouched)
                    {
                        if (letter == 0)
                        {
                            BattleShip.BattleField[index - 1, letter + 1] = Cells.Miss;
                            BattleShip.BattleField[index - 1, letter] = Cells.Miss;
                            BattleShip.BattleField[index, letter + 1] = Cells.Miss;
                        }
                        else if (letter == 9)
                        {
                            BattleShip.BattleField[index - 1, letter - 1] = Cells.Miss;
                            BattleShip.BattleField[index, letter - 1] = Cells.Miss;
                            BattleShip.BattleField[index - 1, letter] = Cells.Miss;
                        }
                        else
                        {
                            BattleShip.BattleField[index, letter - 1] = Cells.Miss;
                            BattleShip.BattleField[index, letter + 1] = Cells.Miss;
                            BattleShip.BattleField[index - 1, letter] = Cells.Miss;
                            BattleShip.BattleField[index - 1, letter + 1] = Cells.Miss;
                            BattleShip.BattleField[index - 1, letter - 1] = Cells.Miss;
                        }
                    }
                    else if (BattleShip.BotField[index - 1, letter] == Cells.Hit)
                    {
                        int cell = 1;
                        while (BattleShip.BotField[index - cell, letter] == Cells.Hit)
                        {
                            cell++;
                        }
                        if (BattleShip.BotField[index - cell, letter] != Cells.Ship)
                        {
                            if (letter == 0)
                            {
                                BattleShip.BattleField[index - cell, letter] = Cells.Miss;
                                for (; cell >= 0; cell--)
                                {
                                    BattleShip.BattleField[index - cell, letter + 1] = Cells.Miss;
                                }
                            }
                            else if (letter == 9)
                            {
                                BattleShip.BattleField[index - cell, letter] = Cells.Miss;
                                for (; cell >= 0; cell--)
                                {
                                    BattleShip.BattleField[index - cell, letter - 1] = Cells.Miss;
                                }
                            }
                            else
                            {
                                BattleShip.BattleField[index - cell, letter] = Cells.Miss;
                                for (; cell >= 0; cell--)
                                {
                                    BattleShip.BattleField[index - cell, letter - 1] = Cells.Miss;
                                    BattleShip.BattleField[index - cell, letter + 1] = Cells.Miss;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (BattleShip.BotField[index + 1, letter] != Cells.Ship & BattleShip.BotField[index - 1, letter] != Cells.Ship)
                {
                    if (BattleShip.BotField[index + 1, letter] == Cells.Untouched & BattleShip.BotField[index - 1, letter] == Cells.Untouched)
                    {
                        if (letter == 0)
                        {
                            BattleShip.BattleField[index - 1, letter] = Cells.Miss;
                            BattleShip.BattleField[index + 1, letter] = Cells.Miss;
                            BattleShip.BattleField[index + 1, letter + 1] = Cells.Miss;
                            BattleShip.BattleField[index, letter + 1] = Cells.Miss;
                            BattleShip.BattleField[index - 1, letter + 1] = Cells.Miss;
                        }
                        else if (letter == 9)
                        {
                            BattleShip.BattleField[index + 1, letter] = Cells.Miss;
                            BattleShip.BattleField[index - 1, letter] = Cells.Miss;
                            BattleShip.BattleField[index, letter - 1] = Cells.Miss;
                            BattleShip.BattleField[index - 1, letter - 1] = Cells.Miss;
                            BattleShip.BattleField[index + 1, letter - 1] = Cells.Miss;
                        }
                        else
                        {
                            BattleShip.BattleField[index - 1, letter] = Cells.Miss;
                            BattleShip.BattleField[index + 1, letter] = Cells.Miss;
                            BattleShip.BattleField[index, letter + 1] = Cells.Miss;
                            BattleShip.BattleField[index, letter - 1] = Cells.Miss;
                            BattleShip.BattleField[index - 1, letter - 1] = Cells.Miss;
                            BattleShip.BattleField[index + 1, letter + 1] = Cells.Miss;
                            BattleShip.BattleField[index - 1, letter + 1] = Cells.Miss;
                            BattleShip.BattleField[index + 1, letter - 1] = Cells.Miss;
                        }
                    }
                    else if (BattleShip.BotField[index - 1, letter] == Cells.Hit || BattleShip.BotField[index + 1, letter] == Cells.Hit)
                    {
                        int CellUp = 1;
                        int CellDown = 1;
                        while (index + CellUp <= 9 && BattleShip.BotField[index + CellUp, letter] == Cells.Hit)
                        {
                            CellUp++;
                        }
                        while (index - CellDown >= 0 && BattleShip.BotField[index - CellDown, letter] == Cells.Hit)
                        {
                            CellDown++;
                        }
                        bool ShipDead = true;
                        if (index + CellUp <= 9)
                        {
                            if (BattleShip.BotField[index + CellUp, letter] == Cells.Ship)
                            {
                                ShipDead = false;
                            }
                        }
                        if (index - CellDown >= 0)
                        {
                            if (BattleShip.BotField[index - CellDown, letter] == Cells.Ship)
                            {
                                ShipDead = false;
                            }
                        }
                        if (ShipDead)
                        {
                            if (index + CellUp <= 9)
                            {
                                BattleShip.BattleField[index + CellUp, letter] = Cells.Miss;
                            }
                            if (index - CellDown >= 0)
                            {
                                BattleShip.BattleField[index - CellDown, letter] = Cells.Miss;
                            }
                            if (letter - 1 >= 0)
                            {
                                for (int i = CellUp - 1; i >= 0; i--)
                                {
                                    BattleShip.BattleField[index + i, letter - 1] = Cells.Miss;
                                }
                                for (int i = CellDown - 1; i >= 0; i--)
                                {
                                    BattleShip.BattleField[index - i, letter - 1] = Cells.Miss;
                                }
                                if (index + CellUp <= 9)
                                {
                                    BattleShip.BattleField[index + CellUp, letter - 1] = Cells.Miss;
                                }
                                if (index - CellDown >= 0)
                                {
                                    BattleShip.BattleField[index - CellDown, letter - 1] = Cells.Miss;
                                }
                            }
                            if (letter + 1 <= 9)
                            {
                                for (int i = CellUp - 1; i >= 0; i--)
                                {
                                    BattleShip.BattleField[index + i, letter + 1] = Cells.Miss;
                                }
                                for (int i = CellDown - 1; i >= 0; i--)
                                {
                                    BattleShip.BattleField[index - i, letter + 1] = Cells.Miss;
                                }
                                if (index + CellUp <= 9)
                                {
                                    BattleShip.BattleField[index + CellUp, letter + 1] = Cells.Miss;
                                }
                                if (index - CellDown >= 0)
                                {
                                    BattleShip.BattleField[index - CellDown, letter + 1] = Cells.Miss;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
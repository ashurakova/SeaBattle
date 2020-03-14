namespace SeaBattleLibrary
{
    public class ShipKillingValidation
    {
        public static void ShipKilling(int Index, int Letter)
        {
            if (Index == 0)
            {
                if (BattleShip.BotField[Index + 1, Letter] != Cells.Ship)
                {
                    if (BattleShip.BotField[Index + 1, Letter] == Cells.Untouched)
                    {
                        if (Letter == 0)
                        {
                            BattleShip.BattleField[Index + 1, Letter + 1] = Cells.Miss;
                            BattleShip.BattleField[Index + 1, Letter] = Cells.Miss;
                            BattleShip.BattleField[Index, Letter + 1] = Cells.Miss;
                        }
                        else if (Letter == 9)
                        {

                            BattleShip.BattleField[Index + 1, Letter - 1] = Cells.Miss;

                            BattleShip.BattleField[Index + 1, Letter] = Cells.Miss;
                            BattleShip.BattleField[Index, Letter - 1] = Cells.Miss;
                        }
                        else
                        {
                            BattleShip.BattleField[Index + 1, Letter + 1] = Cells.Miss;
                            BattleShip.BattleField[Index + 1, Letter] = Cells.Miss;
                            BattleShip.BattleField[Index, Letter + 1] = Cells.Miss;
                            BattleShip.BattleField[Index + 1, Letter - 1] = Cells.Miss;
                            BattleShip.BattleField[Index, Letter - 1] = Cells.Miss;
                        }
                    }
                    else if (BattleShip.BotField[Index + 1, Letter] == Cells.Hit)
                    {
                        int cell = 1;
                        while (BattleShip.BotField[Index + cell, Letter] == Cells.Hit)
                        {
                            cell++;
                        }
                        if (BattleShip.BotField[Index + cell, Letter] != Cells.Ship)
                        {
                            if (Letter == 0)
                            {
                                BattleShip.BattleField[Index + cell, Letter] = Cells.Miss;
                                for (; cell >= Index; cell--)
                                {
                                    BattleShip.BattleField[Index + cell, Letter + 1] = Cells.Miss;
                                }
                            }
                            else if (Letter == 9)
                            {
                                BattleShip.BattleField[Index + cell, Letter] = Cells.Miss;
                                for (; cell >= Index; cell--)
                                {
                                    BattleShip.BattleField[Index + cell, Letter - 1] = Cells.Miss;
                                }
                            }
                            else
                            {
                                BattleShip.BattleField[Index + cell, Letter] = Cells.Miss;
                                for (; cell >= Index; cell--)
                                {
                                    BattleShip.BattleField[Index + cell, Letter - 1] = Cells.Miss;
                                    BattleShip.BattleField[Index + cell, Letter + 1] = Cells.Miss;
                                }
                            }
                        }
                    }
                }
            }
            else if (Index == 9)
            {
                if (BattleShip.BotField[Index - 1, Letter] != Cells.Ship)
                {
                    if (BattleShip.BotField[Index - 1, Letter] == Cells.Untouched)
                    {
                        if (Letter == 0)
                        {
                            BattleShip.BattleField[Index - 1, Letter + 1] = Cells.Miss;
                            BattleShip.BattleField[Index - 1, Letter] = Cells.Miss;
                            BattleShip.BattleField[Index, Letter + 1] = Cells.Miss;
                        }
                        else if (Letter == 9)
                        {
                            BattleShip.BattleField[Index - 1, Letter - 1] = Cells.Miss;
                            BattleShip.BattleField[Index, Letter - 1] = Cells.Miss;
                            BattleShip.BattleField[Index - 1, Letter] = Cells.Miss;
                        }
                        else
                        {
                            BattleShip.BattleField[Index, Letter - 1] = Cells.Miss;
                            BattleShip.BattleField[Index, Letter + 1] = Cells.Miss;
                            BattleShip.BattleField[Index - 1, Letter] = Cells.Miss;
                            BattleShip.BattleField[Index - 1, Letter + 1] = Cells.Miss;
                            BattleShip.BattleField[Index - 1, Letter - 1] = Cells.Miss;
                        }
                    }
                    else if (BattleShip.BotField[Index - 1, Letter] == Cells.Hit)
                    {
                        int cell = 1;
                        while (BattleShip.BotField[Index - cell, Letter] == Cells.Hit)
                        {
                            cell++;
                        }
                        if (BattleShip.BotField[Index - cell, Letter] != Cells.Ship)
                        {
                            if (Letter == 0)
                            {
                                BattleShip.BattleField[Index - cell, Letter] = Cells.Miss;
                                for (; cell >= 0; cell--)
                                {
                                    BattleShip.BattleField[Index - cell, Letter + 1] = Cells.Miss;
                                }
                            }
                            else if (Letter == 9)
                            {
                                BattleShip.BattleField[Index - cell, Letter] = Cells.Miss;
                                for (; cell >= 0; cell--)
                                {
                                    BattleShip.BattleField[Index - cell, Letter - 1] = Cells.Miss;
                                }
                            }
                            else
                            {
                                BattleShip.BattleField[Index - cell, Letter] = Cells.Miss;
                                for (; cell >= 0; cell--)
                                {
                                    BattleShip.BattleField[Index - cell, Letter - 1] = Cells.Miss;
                                    BattleShip.BattleField[Index - cell, Letter + 1] = Cells.Miss;
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (BattleShip.BotField[Index + 1, Letter] != Cells.Ship & BattleShip.BotField[Index - 1, Letter] != Cells.Ship)
                {
                    if (BattleShip.BotField[Index + 1, Letter] == Cells.Untouched & BattleShip.BotField[Index - 1, Letter] == Cells.Untouched)
                    {
                        if (Letter == 0)
                        {
                            BattleShip.BattleField[Index - 1, Letter] = Cells.Miss;
                            BattleShip.BattleField[Index + 1, Letter] = Cells.Miss;
                            BattleShip.BattleField[Index + 1, Letter + 1] = Cells.Miss;
                            BattleShip.BattleField[Index, Letter + 1] = Cells.Miss;
                            BattleShip.BattleField[Index - 1, Letter + 1] = Cells.Miss;
                        }
                        else if (Letter == 9)
                        {
                            BattleShip.BattleField[Index + 1, Letter] = Cells.Miss;
                            BattleShip.BattleField[Index - 1, Letter] = Cells.Miss;
                            BattleShip.BattleField[Index, Letter - 1] = Cells.Miss;
                            BattleShip.BattleField[Index - 1, Letter - 1] = Cells.Miss;
                            BattleShip.BattleField[Index + 1, Letter - 1] = Cells.Miss;
                        }
                        else
                        {
                            BattleShip.BattleField[Index - 1, Letter] = Cells.Miss;
                            BattleShip.BattleField[Index + 1, Letter] = Cells.Miss;
                            BattleShip.BattleField[Index, Letter + 1] = Cells.Miss;
                            BattleShip.BattleField[Index, Letter - 1] = Cells.Miss;
                            BattleShip.BattleField[Index - 1, Letter - 1] = Cells.Miss;
                            BattleShip.BattleField[Index + 1, Letter + 1] = Cells.Miss;
                            BattleShip.BattleField[Index - 1, Letter + 1] = Cells.Miss;
                            BattleShip.BattleField[Index + 1, Letter - 1] = Cells.Miss;
                        }
                    }
                    else if (BattleShip.BotField[Index - 1, Letter] == Cells.Hit || BattleShip.BotField[Index + 1, Letter] == Cells.Hit)
                    {
                        int CellUp = 1;
                        int CellDown = 1;
                        while (Index + CellUp <= 9 && BattleShip.BotField[Index + CellUp, Letter] == Cells.Hit)
                        {
                            CellUp++;
                        }
                        while (Index - CellDown >= 0 && BattleShip.BotField[Index - CellDown, Letter] == Cells.Hit)
                        {
                            CellDown++;
                        }
                        bool ShipDead = true;
                        if (Index + CellUp <= 9)
                        {
                            if (BattleShip.BotField[Index + CellUp, Letter] == Cells.Ship)
                            {
                                ShipDead = false;
                            }
                        }
                        if (Index - CellDown >= 0)
                        {
                            if (BattleShip.BotField[Index - CellDown, Letter] == Cells.Ship)
                            {
                                ShipDead = false;
                            }
                        }
                        if (ShipDead == true)
                        {
                            if (Index + CellUp <= 9)
                            {
                                BattleShip.BattleField[Index + CellUp, Letter] = Cells.Miss;
                            }
                            if (Index - CellDown >= 0)
                            {
                                BattleShip.BattleField[Index - CellDown, Letter] = Cells.Miss;
                            }
                            if (Letter - 1 >= 0)
                            {
                                for (int i = CellUp - 1; i >= 0; i--)
                                {
                                    BattleShip.BattleField[Index + i, Letter - 1] = Cells.Miss;
                                }
                                for (int i = CellDown - 1; i >= 0; i--)
                                {
                                    BattleShip.BattleField[Index - i, Letter - 1] = Cells.Miss;
                                }
                                if (Index + CellUp <= 9)
                                {
                                    BattleShip.BattleField[Index + CellUp, Letter - 1] = Cells.Miss;
                                }
                                if (Index - CellDown >= 0)
                                {
                                    BattleShip.BattleField[Index - CellDown, Letter - 1] = Cells.Miss;
                                }
                            }
                            if (Letter + 1 <= 9)
                            {
                                for (int i = CellUp - 1; i >= 0; i--)
                                {
                                    BattleShip.BattleField[Index + i, Letter + 1] = Cells.Miss;
                                }
                                for (int i = CellDown - 1; i >= 0; i--)
                                {
                                    BattleShip.BattleField[Index - i, Letter + 1] = Cells.Miss;
                                }
                                if (Index + CellUp <= 9)
                                {
                                    BattleShip.BattleField[Index + CellUp, Letter + 1] = Cells.Miss;
                                }
                                if (Index - CellDown >= 0)
                                {
                                    BattleShip.BattleField[Index - CellDown, Letter + 1] = Cells.Miss;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
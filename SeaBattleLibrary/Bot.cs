using System;
using System.Collections;

namespace SeaBattleLibrary
{
    public class Bot : Battleship
    {
        public Bot()
        {
            FourDesk();
            while (Number < 2)
            {
                ThreeDesk();
            }
            Number = 0;
            while (Number < 3)
            {
                TwoDesk();
            }
            Number = 0;
            while (Number < 4)
            {
                OneDesk();
            }
        }
        private void FourDesk()
        {
            var random = new Random();
            int x = random.Next(0, 9);
            int y = random.Next(0, 9);
            if (y > 5)
            {
                for (int i = y; i > y - 4; i--)
                {
                    BotField[i, x] = 1;
                }
            }
            else
            {
                for (int i = y; i < y + 4; i++)
                {
                    BotField[i, x] = 1;
                }
            }
        }
        private void ThreeDesk()
        {
            var random = new Random();
            int x = random.Next(0, 9);
            int y = random.Next(0, 9);
            ArrayList Coordinates = new ArrayList();
            bool creation;
            if (y > 5)
            {
                for (int i = y; i > y - 3; i--)
                {
                    Coordinates.Add(i);
                }
                creation = ShipCreation(Coordinates, x);
                if (creation == true)
                {
                    for (int i = y; i > y - 3; i--)
                    {
                        BotField[i, x] = 1;
                    }
                    Number++;
                }
            }
            else if (y <= 5)
            {
                for (int i = y; i > y + 3; i++)
                {
                    Coordinates.Add(i);

                }
                creation = ShipCreation(Coordinates, x);
                if (creation == true)
                {
                    for (int i = y; i < y + 3; i++)
                    {
                        BotField[i, x] = 1;
                    }
                    Number++;
                }
            }
        }
        private void TwoDesk()
        {
            var random = new Random();
            int x = random.Next(0, 9);
            int y = random.Next(0, 9);

            ArrayList Coordinates = new ArrayList();
            bool creation;
            if (y > 5)
            {
                for (int i = y; i > y - 2; i--)
                {
                    Coordinates.Add(i);
                }
                creation = ShipCreation(Coordinates, x);
                if (creation == true)
                {
                    for (int i = y; i > y - 2; i--)
                    {
                        BotField[i, x] = 1;
                    }
                    Number++;
                }
            }
            else if (y <= 5)
            {
                for (int i = y; i > y + 2; i++)
                {
                    Coordinates.Add(i);
                }
                creation = ShipCreation(Coordinates, x);
                if (creation == true)
                {
                    for (int i = y; i < y + 2; i++)
                    {
                        BotField[i, x] = 1;
                    }
                    Number++;
                }
            }
        }

        private void OneDesk()
        {
            var random = new Random();
            int x = random.Next(0, 9);
            int y = random.Next(0, 9);

            ArrayList Coordinates = new ArrayList();
            bool creation;
            Coordinates.Add(y);
            creation = ShipCreation(Coordinates, x);
            if (creation == true)
            {
                BotField[y, x] = 1;
                Number++;
            }
        }

        public bool ShipCreation(ArrayList list, int x)
        {
            int counter = 0;
            foreach (int i in list)
            {
                if (BotField[i, x] == 1)
                {
                    counter++;
                }
                else if (i == 0)
                {
                    if (x == 0)
                    {
                        if (BotField[i + 1, x] == 1 || BotField[i, x + 1] == 1 || BotField[i + 1, x + 1] == 1)
                        {
                            counter++;
                        }
                    }
                    else if (x == 9)
                    {
                        if (BotField[i + 1, x] == 1 || BotField[i, x - 1] == 1 || BotField[i + 1, x - 1] == 1)
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        if (BotField[i, x - 1] == 1 || BotField[i, x + 1] == 1 || BotField[i + 1, x] == 1 || BotField[i + 1, x + 1] == 1 || BotField[i + 1, x - 1] == 1)
                        {
                            counter++;
                        }
                    }
                }
                else if (i == 9)
                {
                    if (x == 0)
                    {
                        if (BotField[i - 1, x] == 1 || BotField[i - 1, x + 1] == 1 || BotField[i, x + 1] == 1)
                        {
                            counter++;
                        }
                    }
                    else if (x == 9)
                    {
                        if (BotField[i - 1, x] == 1 || BotField[i, x - 1] == 1 || BotField[i - 1, x - 1] == 1)
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        if (BotField[i, x - 1] == 1 || BotField[i, x + 1] == 1 || BotField[i - 1, x] == 1 || BotField[i - 1, x - 1] == 1 || BotField[i - 1, x + 1] == 1)
                        {
                            counter++;
                        }
                    }
                }
                else
                {
                    if (x == 0)
                    {
                        if (BotField[i - 1, x] == 1 || BotField[i + 1, x] == 1 || BotField[i, x + 1] == 1 || BotField[i - 1, x + 1] == 1 || BotField[i + 1, x + 1] == 1)
                        {
                            counter++;
                        }
                    }
                    else if (x == 9)
                    {
                        if (BotField[i, x - 1] == 1 || BotField[i - 1, x] == 1 || BotField[i + 1, x] == 1 || BotField[i - 1, x - 1] == 1 || BotField[i + 1, x - 1] == 1)
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        if (BotField[i, x - 1] == 1 || BotField[i - 1, x] == 1 || BotField[i + 1, x] == 1 || BotField[i - 1, x - 1] == 1 ||
                            BotField[i + 1, x - 1] == 1 || BotField[i, x + 1] == 1 || BotField[i + 1, x + 1] == 1 || BotField[i - 1, x + 1] == 1)
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
using System;

namespace SeaBattleLibrary
{
    public class User : Battleship
    {
        public void Strike()
        {
            if (Win())
            {
                return;
            }
            Console.SetCursorPosition(30, Indent++);
            Console.WriteLine("Выстрел №: " + Step);
            Boolean letter = true;
            try
            {
                while (letter)
                {
                    Console.SetCursorPosition(30, Indent++);
                    Console.Write("Ваш выстрел:");
                    switch (Console.Read())
                    {
                        case 'а':
                            Letter[Step] = 0;
                            letter = false;
                            break;
                        case 'б':
                            Letter[Step] = 1;
                            letter = false;
                            break;
                        case 'в':
                            Letter[Step] = 2;
                            letter = false;
                            break;
                        case 'г':
                            Letter[Step] = 3;
                            letter = false;
                            break;
                        case 'д':
                            Letter[Step] = 4;
                            letter = false;
                            break;
                        case 'е':
                            Letter[Step] = 5;
                            letter = false;
                            break;
                        case 'ж':
                            Letter[Step] = 6;
                            letter = false;
                            break;
                        case 'з':
                            Letter[Step] = 7;
                            letter = false;
                            break;
                        case 'и':
                            Letter[Step] = 8;
                            letter = false;
                            break;
                        case 'к':
                            Letter[Step] = 9;
                            letter = false;
                            break;
                        default:
                            Console.SetCursorPosition(30, Indent++);
                            Console.WriteLine("Пожалуйста, введите строчную букву от а до до к и цифру от 1 до 10 в формате 'a1'.");
                            break;
                    }
                    Index[Step] = Convert.ToInt32(Console.ReadLine()) - 1;
                }
                Hit(Index[Step], Letter[Step]);
                Step++;
            }
            catch {}
        }

        public bool Hit(int i, int j)
        {
            if (BotField[i, j] == 0)
            {
                BotField[i, j] = 3;
                BattleField[i, j] = 3;
                Output(BattleField);
                Console.SetCursorPosition(30, 0);
                Console.Write("Промах!");
                return false;
            }
            if (BotField[i, j] == 1)
            {
                BotField[i, j] = 2;
                BattleField[i, j] = 2;
                Output(BattleField);
                Points++;
                Console.SetCursorPosition(30, 0);
                Console.Write("Попадание!");
                return true;
            }
            Console.SetCursorPosition(30, 0);
            Console.Write("Нельзя стрелять в эту клетку");
            Console.SetCursorPosition(30, 4);
            Console.WriteLine();
            Step--;
            return true;
        }

        public bool Win()
        {
            if (Points == 20)
            {
                Console.SetCursorPosition(10, 0);
                Console.Write("Вы победили!");
                return true;
            }
            return false;
        }
    }
}
using System;

namespace SeaBattleLibrary
{
    public class User
    {
        public static int Step = 0;
        public static int[] Letter = new int[100];
        public static int[] Index = new int[100];
        public void StepMaking()
        {
            Console.SetCursorPosition(30, BattleShip.Indent++);
            Console.WriteLine("Выстрел №: " + (Step+1));
            bool LetterValid = false;
            while (LetterValid != true)
            {
                Console.SetCursorPosition(30, BattleShip.Indent++);
                Console.Write("Ваш выстрел:");
                switch (Console.Read())
                {
                        case 'а':
                            Letter[Step] = 0;
                            LetterValid = true;
                            break;
                        case 'б':
                            Letter[Step] = 1;
                            LetterValid = true;
                            break;
                        case 'в':
                            Letter[Step] = 2;
                            LetterValid = true;
                            break;
                        case 'г':
                            Letter[Step] = 3;
                            LetterValid = true;
                            break;
                        case 'д':
                            Letter[Step] = 4;
                            LetterValid = true;
                            break;
                        case 'е':
                            Letter[Step] = 5;
                            LetterValid = true;
                            break;
                        case 'ж':
                            Letter[Step] = 6;
                            LetterValid = true;
                            break;
                        case 'з':
                            Letter[Step] = 7;
                            LetterValid = true;
                            break;
                        case 'и':
                            Letter[Step] = 8;
                            LetterValid = true;
                            break;
                        case 'к':
                            Letter[Step] = 9;
                            LetterValid = true;
                            break;
                        default:
                            Console.SetCursorPosition(30, BattleShip.Indent++);
                            Console.WriteLine("Пожалуйста, введите строчную букву от а до до к и цифру от 1 до 10 в формате 'a1'.");
                            break;
                    }
                if (LetterValid == true)
                {
                    try
                    {
                        Index[Step] = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (Index[Step] >= 0 && Index[Step] < 10)
                        {
                            string ConsoleClear = "                            ";
                            Console.SetCursorPosition(30, 0);
                            Console.WriteLine(ConsoleClear);
                            if (BattleShip.BotField[Index[Step], Letter[Step]] == 0)
                            {
                                BattleShip.BotField[Index[Step], Letter[Step]] = 3;
                                BattleShip.BattleField[Index[Step], Letter[Step]] = 3;
                                BattleShip.Output(BattleShip.BattleField);
                                Console.SetCursorPosition(30, 0);
                                Console.Write("Промах!");
                                Step++;
                            }
                            else if (BattleShip.BotField[Index[Step], Letter[Step]] == 1)
                            {
                                BattleShip.BotField[Index[Step], Letter[Step]] = 2;
                                BattleShip.BattleField[Index[Step], Letter[Step]] = 2;
                                BattleShip.Output(BattleShip.BattleField);
                                BattleShip.Points++;
                                Console.SetCursorPosition(30, 0);
                                Console.Write("Попадание!");
                                Step++;
                            }
                            else
                            {
                                Console.SetCursorPosition(30, 0);
                                Console.Write("Нельзя стрелять в эту клетку");
                                Console.SetCursorPosition(30, 4);
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.SetCursorPosition(30, BattleShip.Indent++);
                            Console.WriteLine("Пожалуйста, введите строчную букву от а до до к и цифру от 1 до 10 в формате 'a1'.");
                        }

                    }
                    catch
                    {
                        Console.SetCursorPosition(30, BattleShip.Indent++);
                        Console.WriteLine("Пожалуйста, введите строчную букву от а до до к и цифру от 1 до 10 в формате 'a1'.");
                    }
                }
            } 
        }
    }
}
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
            Console.WriteLine("Выстрел №: " + (Step + 1));
            Console.SetCursorPosition(30, BattleShip.Indent++);
            Console.Write("Ваш выстрел:");
            string InputtedValue = Console.ReadLine();
            bool ValidStepMade = false;
            while (ValidStepMade==false)
            {
               
                int InputtedLetter;
                int InputtedNumber;

                bool InputValidity = UserStepValidation.StepValidation(InputtedValue, out InputtedLetter, out InputtedNumber);
                if (InputValidity == true)
                {
                    Console.SetCursorPosition(30, 0);
                    Console.WriteLine("HELLO");
                    Letter[Step] = InputtedLetter;
                    Index[Step] = InputtedNumber;
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
                    ValidStepMade = true;
                }
                else
                {
                    Console.SetCursorPosition(30, BattleShip.Indent++);
                    Console.WriteLine("Пожалуйста, введите строчную букву от а до до к и цифру от 1 до 10 в формате 'a1'.");
                    ValidStepMade = false;
                    break; 
                }
            }
        }
    }
}
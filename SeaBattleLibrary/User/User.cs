using System;
using System.Text.RegularExpressions;

namespace SeaBattleLibrary
{
    public class User
    {
        public static int Step = 0;
        public static int[] Letter = new int[100];
        public static int[] Index = new int[100];
        string regex = "^[а-к][1-9]$|^[а-к]10$";
        public void StepMaking()
        {
            Console.SetCursorPosition(30, BattleShip.Indent++);
            Console.WriteLine("Выстрел №: " + (Step + 1));
            bool ValidStepDone = false;
            while (ValidStepDone == false)
            {
                Console.SetCursorPosition(30, BattleShip.Indent++);
                Console.Write("Ваш выстрел:");
                string InputtedValue = Console.ReadLine().ToLower();
                bool InputValidity = Regex.Match(InputtedValue, regex).Success;
                if (InputValidity == false)
                {
                    Console.SetCursorPosition(30, BattleShip.Indent++);
                    Console.WriteLine("Пожалуйста, введите строчную букву от а до к и цифру от 1 до 10 в формате 'a1'.");
                    ValidStepDone = false;
                }
                else
                {
                    int ValidLetter;
                    int ValidNumber;
                    UserStepValidation.StepValidation(InputtedValue, out ValidLetter, out ValidNumber);
                    Console.SetCursorPosition(30, 0);
                    Letter[Step] = ValidLetter;
                    Index[Step] = ValidNumber;
                    string ConsoleClear = "                             ";
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
                        ValidStepDone = true;
                    }
                    else if (BattleShip.BotField[Index[Step], Letter[Step]] == 1)
                    {
                        BattleShip.BotField[Index[Step], Letter[Step]] = 2;
                        BattleShip.BattleField[Index[Step], Letter[Step]] = 2;
                        BattleShip.Output(BattleShip.BattleField);
                        ShipKillingValidation.ShipKilling(Index[Step], Letter[Step]);
                        BattleShip.Points++;
                        Console.SetCursorPosition(30, 0);
                        Console.Write("Попадание!");
                        Step++;
                        ValidStepDone = true;
                    }
                    else
                    {
                        Console.SetCursorPosition(30, 0);
                        Console.Write("Нельзя стрелять в эту клетку.");
                        ValidStepDone = false;
                    }
                }
            }
        }
    }
}
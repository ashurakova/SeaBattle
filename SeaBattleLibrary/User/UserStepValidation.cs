using System;

namespace SeaBattleLibrary
{
    public class UserStepValidation
    {
        public static void StepValidation(string InputtedValue, out int ValidLetter, out int ValidNumber)
        {
            ValidNumber = Int32.Parse(InputtedValue.Substring(1)) - 1;
            char InputtedLetter = InputtedValue[0];
            ValidLetter=0;
            switch (InputtedLetter)
            {
                case 'а':
                    ValidLetter = 0;
                    break;
                case 'б':
                    ValidLetter = 1;
                    break;
                case 'в':
                    ValidLetter = 2;
                    break;
                case 'г':
                    ValidLetter = 3;
                    break;
                case 'д':
                    ValidLetter = 4;
                    break;
                case 'е':
                    ValidLetter = 5;
                    break;
                case 'ж':
                    ValidLetter = 6;
                    break;
                case 'з':
                    ValidLetter = 7;
                    break;
                case 'и':
                    ValidLetter = 8;
                    break;
                case 'к':
                    ValidLetter = 9;
                    break;
            }
        }
    }
}
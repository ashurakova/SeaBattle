using System;

namespace SeaBattleLibrary
{
    public class UserStepValidation
    {
        public static void StepValidation(string z, out int ValidLetter, out int ValidNumber)
        {
            int InputtedNumber = Int32.Parse(z.Substring(1)) - 1;
            ValidNumber = InputtedNumber;
            char InputtedLetter = z[0];
            int Letter = 0;
            switch (InputtedLetter)
            {
                case 'а':
                    Letter = 0;
                    break;
                case 'б':
                    Letter = 1;
                    break;
                case 'в':
                    Letter = 2;
                    break;
                case 'г':
                    Letter = 3;
                    break;
                case 'д':
                    Letter = 4;
                    break;
                case 'е':
                    Letter = 5;
                    break;
                case 'ж':
                    Letter = 6;
                    break;
                case 'з':
                    Letter = 7;
                    break;
                case 'и':
                    Letter = 8;
                    break;
                case 'к':
                    Letter = 9;
                    break;
            }
            ValidLetter = Letter;
        }
    }
}
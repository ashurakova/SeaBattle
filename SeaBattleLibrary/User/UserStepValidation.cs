using System;

namespace SeaBattleLibrary
{
    public class UserStepValidation
    {
        public static void StepValidation(string inputtedValue, out int validLetter, out int validNumber)
        {
            validNumber = Int32.Parse(inputtedValue.Substring(1)) - 1;
            char InputtedLetter = inputtedValue[0];
            validLetter=0;
            switch (InputtedLetter)
            {
                case 'а':
                    validLetter = 0;
                    break;
                case 'б':
                    validLetter = 1;
                    break;
                case 'в':
                    validLetter = 2;
                    break;
                case 'г':
                    validLetter = 3;
                    break;
                case 'д':
                    validLetter = 4;
                    break;
                case 'е':
                    validLetter = 5;
                    break;
                case 'ж':
                    validLetter = 6;
                    break;
                case 'з':
                    validLetter = 7;
                    break;
                case 'и':
                    validLetter = 8;
                    break;
                case 'к':
                    validLetter = 9;
                    break;
            }
        }
    }
}
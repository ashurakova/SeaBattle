using System;

namespace SeaBattleLibrary
{
    public class UserStepValidation
    {
        public static bool StepValidation(string z, out int ValidLetter, out int ValidNumber)
        { 
            char InputtedLetter = z[0];
            int CheckedLetter;
            LetterValidation(InputtedLetter, out CheckedLetter);
            int CheckedNumber;
            try
            {
                int InputtedNumber = Int32.Parse(z.Substring(1));
                NumberValidation(InputtedNumber, out InputtedNumber);
                CheckedNumber = InputtedNumber;
            }
            catch
            {
                CheckedNumber = -1;
            }

            if (CheckedLetter != -1 && CheckedNumber != -1)
            {
                ValidLetter = CheckedLetter;
                ValidNumber = CheckedNumber;
                return true;
            }
            else
            {
                ValidLetter = -1;
                ValidNumber = -1;
                return false;
            }
        }

        private static void LetterValidation(char z, out int CheckedLetter)
        {
            int Letter=-1;
            switch (z)
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
            if (Letter >= 0 && Letter < 10)
            {
                CheckedLetter = Letter;
            }
            else
            {
                CheckedLetter = Letter;
            }
        }
        private static void NumberValidation (int z, out int CheckedNumber)
        {
            if (z>0&&z<11)
            {
                CheckedNumber = z - 1;
            }
            else
            {
                CheckedNumber = -1;
            }
                
        }
    }
}
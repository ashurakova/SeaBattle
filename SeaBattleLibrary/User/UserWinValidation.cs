using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBattleLibrary
{
    public class UserWinValidation
    {
        public static char LetterInput { get; private set; }

        public static bool Win()
        {
            if (BattleShip.Points == 20)
            {
                return true;
            }
            return false;
        }
    }
}
using System;

namespace SeaBattleLibrary
{
    public class Battleship
    {
        public int[,] BattleField = new int[10, 10]; // Поле, которое показывается пользователю. 0 - пустая клетка, 1 - корабль, 2 - попадание по кораблю, 3 - промах
        public static int[,] BotField = new int[10, 10];
        public static readonly string[] StrLetters = { "а", "б", "в", "г", "д", "е", "ж", "з", "и", "к" };
        public static readonly string[] StrNumbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        public int Step = 1;
        protected int[] Letter = new int[100];
        protected int[] Index = new int[100];
        public int Points = 0;
        public static int Indent = 2;
        public int Number;
        public void Output(int[,] Field)
        {
            if (Indent > 20)
            {
                Indent = 2;
                Console.Clear();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(2 * i + 3, 0);
                Console.Write(StrLetters[i]);
                Console.SetCursorPosition(0, i + 1);
                Console.Write(StrNumbers[i]);
                Console.SetCursorPosition(2, i + 1);
                Console.Write("| ");
                for (int j = 0; j < 10; j++)
                {
                    Console.SetCursorPosition(2 * j + 3, i + 1);
                    Part(Field[i, j]);
                }
            }
        }

        public void Part(int a)
        {
            switch (a)
            {
                case 0:
                    Console.Write('+');
                    break;
                case 1:
                    Console.Write('■');
                    break;
                case 2:
                    Console.Write('X');
                    break;
                case 3:
                    Console.Write('O');
                    break;
            }
        }
    }
}
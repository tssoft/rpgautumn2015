using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BombermanConsole
{
    public static class Drawing
    {
        private static string[,] gameField;

        public static Game Game
        {
            get;
            set;
        }

        public static void DrawField()
        {
            gameField = new string[20, 50];
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    gameField[i, j] = " ";
                }
            }

            foreach (GameObject o in Game.Objects)
            {
                switch (o.GetObjectType())
                {
                    case GameTypes.MetallWall:
                        gameField[o.Position.X, o.Position.Y] = "M";
                        break;
                    case GameTypes.Player:
                        gameField[o.Position.X, o.Position.Y] = "1";
                        break;
                    case GameTypes.BrickWall:
                        gameField[o.Position.X, o.Position.Y] = "X";
                        break;
                    case GameTypes.Bomb:
                        gameField[o.Position.X, o.Position.Y] = "O";
                        break;
                    case GameTypes.Door:
                        gameField[o.Position.X, o.Position.Y] = "D";
                        break;
                    case GameTypes.Explosion:
                        gameField[o.Position.X, o.Position.Y] = "*";
                        break;
                    case GameTypes.Enemy:
                        gameField[o.Position.X, o.Position.Y] = "i";
                        break;
                }

            }
        }

        public static void ShowField()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    Console.Write(gameField[i, j]);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}

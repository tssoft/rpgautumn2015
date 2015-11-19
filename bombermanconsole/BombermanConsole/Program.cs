using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BombermanConsole
{
    sealed class Program
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int keys);

        public static void Main()
        {
            var game = new Game();
            Drawing.Game = game;
            game.Load("..\\..\\map.cs");

            // Q (quit)
            while (!game.IsGameOver && GetAsyncKeyState(0x51) == 0 )
            {
                game.ProcessObjects();
                Drawing.DrawField();
                Drawing.ShowField();
                Console.SetCursorPosition(0, 0);
            }

            Console.WriteLine("Game over!");
            Console.ReadLine();
        }
    }
}

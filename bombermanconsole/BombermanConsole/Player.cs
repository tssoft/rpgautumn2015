using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BombermanConsole
{
    public class Player : Walker
    {
        public Player(Point pos, Game g) : base(pos, g)
        {

        }

        public override GameTypes GetObjectType()
        {
            return GameTypes.Player;
        }

        public override void Process()
        {
            prevPosition = Position;

            // Шаг влево
            if (GetAsyncKeyState(0x26) != 0)
            {
                Position = new Point(Position.X - cellStep,
                                     Position.Y);
            }
            // Шаг вверх
            else if (GetAsyncKeyState(0x25) != 0)
            {
                Position = new Point(Position.X ,
                                     Position.Y - cellStep);
            }
            // Шаг вправо
            else if (GetAsyncKeyState(0x28) != 0)
            {
                Position = new Point(Position.X + cellStep,
                                     Position.Y);
            }
            // Шаг вниз
            else if (GetAsyncKeyState(0x27) != 0)
            {
                Position = new Point(Position.X,
                                     Position.Y + cellStep);
            }
            // Поставить бомбу
            else if (GetAsyncKeyState(0x20) != 0)
            {
                Game.Children.Add(new Bomb(Position, Game, 50));
            }

            base.Process();
        }

        protected override void CollisionHandler(GameObject other)
        {
            switch (other.GetObjectType())
            {
                case GameTypes.Enemy:
                    IsDie = true;
                    Game.Trash.Add(this);
                    Game.IsGameOver = true;
                    break;
            }
        }
    }
}

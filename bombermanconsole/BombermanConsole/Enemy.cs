using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BombermanConsole
{
    public class Enemy : Walker
    {
        private int timer = 10;

        public Enemy(Point pos, Game g)
             : base(pos, g)
        {

        }

        public override GameTypes GetObjectType()
        {
            return GameTypes.Enemy;
        }

        public override void Process()
        {
            if (timer > 0)
            {
                timer--;
                return;
            }

            prevPosition = Position;
            Random rnd = new Random();
            switch (rnd.Next(3))
            {
                case 0: Position = new Point(Position.X - cellStep,
                                             Position.Y);
                    break;
                case 1: Position = new Point(Position.X + cellStep,
                                             Position.Y);
                    break;
                case 2: Position = new Point(Position.X ,
                                             Position.Y - cellStep);
                    break;
                case 3: Position = new Point(Position.X,
                                             Position.Y + cellStep);
                    break;
            }

            timer = 10;
            base.Process();
        }
    }
}

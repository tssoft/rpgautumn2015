using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BombermanConsole
{
    public class Door : GameObject
    {
        public Door(Point pos, Game g)
             : base(pos, g)
        {

        }

        public override void Process()
        {
            base.Process();

            foreach (GameObject o in Game.Objects)
            {
                if (IsCollision(o))
                {
                    switch (o.GetObjectType())
                    {
                        case GameTypes.Player:
                            Game.IsGameOver = true;
                            break;
                    }
                }
            }
        }

        public override GameTypes GetObjectType()
        {
            return GameTypes.Door;
        }
    }
}

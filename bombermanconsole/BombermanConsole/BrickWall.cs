using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BombermanConsole
{
    public class BrickWall : GameObject
    {
        public BrickWall(Point pos, Game g)
             : base(pos, g)
        {

        }

        public override GameTypes GetObjectType()
        {
            return GameTypes.BrickWall;
        }
    }
}

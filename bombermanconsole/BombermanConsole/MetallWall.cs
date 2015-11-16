using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BombermanConsole
{
    public class MetallWall : GameObject
    {
        public MetallWall(Point pos, Game g) 
             : base(pos, g)
        {

        }

        public override GameTypes GetObjectType()
        {
            return GameTypes.MetallWall;
        }
    }
}

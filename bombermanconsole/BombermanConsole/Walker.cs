using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BombermanConsole
{
    public abstract class Walker : GameObject
    {
        /// <summary>
        /// Предыдущая позиция персонажа
        /// </summary>
        protected Point prevPosition = new Point(0, 0);

        public Point PrevPosition
        {
            get { return prevPosition; }
            //set { prevPosition = value; }
        }

         public Walker(Point pos, Game g) 
              : base(pos, g)
        {

        }

         public override void HandleCollision(GameObject other)
         {
             switch (other.GetObjectType())
             {
                 case GameTypes.BrickWall:
                 case GameTypes.MetallWall:
                 case GameTypes.Bomb:
                     Position = prevPosition;
                     break;
             }
         }

        public override void Process()
        {
            foreach (GameObject o in Game.Objects)
            {
                if (IsCollision(o))
                {
                    HandleCollision(o);
                }
            }
        }
    }
}

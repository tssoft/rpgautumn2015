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
        protected Point prevPosition;

         public Walker(Point pos, Game g) 
              : base(pos, g)
        {

        }

        public override void Process()
        {
            foreach (GameObject o in Game.Objects)
            {
                if (IsCollision(o))
                {
                    switch (o.GetObjectType())
                    {
                        case GameTypes.BrickWall:
                        case GameTypes.MetallWall:
                        case GameTypes.Bomb:
                            Position = prevPosition;
                            break;
                    }
                    CollisionHandler(o);
                }
            }
        }
    }
}

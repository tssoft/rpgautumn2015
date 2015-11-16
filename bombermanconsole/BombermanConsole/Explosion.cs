using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BombermanConsole
{
    public class Explosion : GameObject
    {
        private int timer;
    
        public Explosion(Point pos, Game g, int t)
             : base(pos, g)
        {
            timer = t;
        }

        public override GameTypes GetObjectType()
        {
            return GameTypes.Explosion;
        }

        public override void Process()
        {
            base.Process();

            foreach (GameObject o in Game.Objects)
            {
                if (IsCollision(o))
                {
                    CollisionHandler(o);
                }
            }

            timer--;
            if (timer <= 0)
            {
                Game.Trash.Add(this);
            }
        }

        /// <summary>
        /// Обрабатывает столкновение
        /// </summary>
        protected override void CollisionHandler(GameObject other)
        {
            switch (other.GetObjectType())
            {
                case GameTypes.Enemy:
                case GameTypes.BrickWall:
                    other.IsDie = true;
                    Game.Trash.Add(other);
                    break;
                case GameTypes.Player:
                    other.IsDie = true;
                    Game.Trash.Add(other);
                    Game.IsGameOver = true;
                    break;
                case GameTypes.MetallWall:
                    timer = 1;
                    break;
            }
        }
    }
}

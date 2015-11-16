using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BombermanConsole
{
    public class Bomb : GameObject
    {
        private int timer;
    
        public Bomb(Point pos, Game g, int t) 
             : base(pos, g)
        {
            timer = t;
        }

        public override void Process()
        {
            timer--;
            if (timer <= 0)
            {
                int t = 7;
                Game.Children.Add(new Explosion(Position, Game, t));
                Game.Children.Add(new Explosion(new Point(Position.X - cellStep,
                                                          Position.Y),
                                                Game,
                                                t));
                Game.Children.Add(new Explosion(new Point(Position.X + cellStep,
                                                          Position.Y),
                                                Game,
                                                t));
                Game.Children.Add(new Explosion(new Point(Position.X,
                                                          Position.Y + cellStep),
                                                Game,
                                                t));
                Game.Children.Add(new Explosion(new Point(Position.X,
                                                          Position.Y - cellStep),
                                                Game,
                                                t));
                Game.Trash.Add(this);
            }
        }

        public override GameTypes GetObjectType()
        {
            return GameTypes.Bomb;
        }
    }
}

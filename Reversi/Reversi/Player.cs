using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reversi
{
    public class Player : IPlayer
    {
        private int name;
        private int color;

        public Gameplay Gameplay
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void PointOnCell()
        {
            throw new System.NotImplementedException();
        }
    }
}

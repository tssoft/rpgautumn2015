﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reversi
{
    public class Chip : IChip
    {
        public int color;

        public Cell Cell
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Flip()
        {
            throw new System.NotImplementedException();
        }
    }
}

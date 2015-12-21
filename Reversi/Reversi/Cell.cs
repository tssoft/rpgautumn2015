using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reversi
{
    public class Cell
    {
        private int Chip;
        private int ID;
        private int bottomCellStatus;
        private int upperCellStatus;
        private int rightCellStatus;
        private int leftCellStatus;
    
        public GameBoard GameBoard
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reversi
{
    public class GameManager
    {
        private int numberOfMove;

        public void StartGame()
        {
            throw new System.NotImplementedException();
        }

        public void DetermineWinner()
        {
            throw new System.NotImplementedException();
        }

        public void StartTurn()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateGameScore()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Gameplay
    {
        public IChip IChip
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Finder Finder
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public void CheckCell()
        {
            throw new System.NotImplementedException();
        }

        public void FlipChips()
        {
            throw new System.NotImplementedException();
        }

        public void PutChip()
        {
            throw new System.NotImplementedException();
        }
    }
}

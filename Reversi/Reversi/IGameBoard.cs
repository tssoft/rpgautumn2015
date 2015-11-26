using System;
namespace Reversi
{
    interface IGameBoard
    {
        void CheckCell();
        void GetCellState();
    }
}

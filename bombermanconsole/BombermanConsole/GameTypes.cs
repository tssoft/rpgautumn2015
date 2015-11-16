using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BombermanConsole
{
    public enum GameTypes
    {
        /// <summary>
        /// Тип металлическая стена
        /// </summary>
        MetallWall = 0,
        /// <summary>
        /// Тип кирпичная стена
        /// </summary>
        BrickWall = 1,
        /// <summary>
        /// Тип противник
        /// </summary>
        Enemy = 2,
        /// <summary>
        /// Тип взрыв
        /// </summary>
        Explosion = 3,
        /// <summary>
        /// Тип бомба
        /// </summary>
        Bomb = 4,
        /// <summary>
        /// Тип игрок
        /// </summary>
        Door = 5,
        Player = 6,
    }
}

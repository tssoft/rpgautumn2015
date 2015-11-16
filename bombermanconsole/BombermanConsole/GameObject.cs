using System.Drawing;
using System.Runtime.InteropServices;

namespace BombermanConsole
{
    public abstract class GameObject
    {
        /// <summary>
        /// Содержит шаг сетки.
        /// </summary>
        protected const int cellStep = 1;

        /// <summary>
        /// Позиция объекта на карте. Задается парой координат в структуре pos.
        /// </summary>
        public Point Position { get; set; }

        /// <summary>
        /// Указывает существует ли объект
        /// </summary>
        public bool IsDie { get; set; }

        /// <summary>
        /// Хранит ссылку на текущую игру
        /// </summary>
        public Game Game { get; set; }

        public GameObject(Point pos, Game g)
        {
            Position = pos;
            Game = g;
        }

        /// <summary>
        /// Получает тип объекта
        /// </summary>
        /// <remarks>Тип объекта</remarks>
        public abstract GameTypes GetObjectType();

        /// <summary>
        /// Обрабатывает действия объекта за один игровой цикл
        /// </summary>
        public virtual void Process()
        {
            if (IsDie) return;
        }

        /// <summary>
        /// Проверяет, не столкнулись ли объекты
        /// </summary>
        protected bool IsCollision(GameObject other)
        {
            if (!other.IsDie & Position == other.Position)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Обрабатывает столкновение
        /// </summary>
        protected virtual void CollisionHandler(GameObject other)
        {

        }

        [DllImport("user32.dll")]
        protected static extern short GetAsyncKeyState(int keys);
    }
}

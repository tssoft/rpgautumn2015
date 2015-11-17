using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace BombermanConsole
{
    public class Game
    {
        /// <summary>
        /// Коллекция всех объектов на карте
        /// </summary>
        private ICollection<GameObject> objects = new List<GameObject>();

        private ICollection<GameObject> children = new List<GameObject>();

        public ICollection<GameObject> Children
        {
            get { return children; }
        }

        public ICollection<GameObject> Objects
        {
            get { return objects; }
        }

        /// <summary>
        /// Коллекция объектов для удаления
        /// </summary>
        private ICollection<GameObject> trash = new LinkedList<GameObject>();

        public ICollection<GameObject> Trash
        {
            get { return trash; }
        }

        /// <summary>
        /// Указывает на то, что игра окончена
        /// </summary>
        public bool IsGameOver { get; set; }

        /// <summary>
        /// Формирует список объектов
        /// </summary>
        /// <param name="file">Карта, хранящая список объектов</param>
        public void Load(string file)
        {
            IList<string> map = new List<string>();
            using (var sr = new StreamReader(file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    map.Add(line);
                }
            }

            Objects.Add(new Player(new Point(1, 1), this));
            Objects.Add(new Door(new Point(1, 31), this));
            for (int i = 0; i < map.Count; i++)
            {
                for (int j = 0; j < map[0].Length; j++)
                {
                    switch (map[i][j])
                    {
                        case 'M':
                            Objects.Add(new MetallWall(new Point(i, j), this));
                            break;
                        case 'X':
                            Objects.Add(new BrickWall(new Point(i, j), this));
                            break;
                        case 'i':
                            Objects.Add(new Enemy(new Point(i, j), this));
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Инициирует взаимодействие объектов
        /// </summary>
        public void ProcessObjects()
        {
            if (Children.Count > 0)
            {
                foreach (GameObject o in Children)
                {
                    Objects.Add(o);
                }
                Children.Clear();
            }

            if (Objects.Count > 0)
            {
                foreach (GameObject o in Objects)
                {
                    o.Process();
                }
            }

            if (Trash.Count > 0)
            {
                foreach (GameObject o in Trash)
                {
                    Objects.Remove(o);
                }
                Trash.Clear();
            }
        }
    }
}

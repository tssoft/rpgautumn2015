using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BombermanConsole;
using System.Drawing;

namespace BombernamTests
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void TestHandleCollisionPlayerWall()
        {
            var game = new Game();
            var player = new Player(new Point(1, 0), game);
            var wall = new BrickWall(new Point(1, 0), game);

            var expected = player.PrevPosition;

            player.HandleCollision(wall);

            var actual = player.Position;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestHandleCollisionPlayerEnemy()
        {
            var game = new Game();
            var player = new Player(new Point(1, 1), game);
            var enemy = new Enemy(new Point(1, 1), game);

            bool expected = true;

            player.HandleCollision(enemy);

            var actual = player.IsDie;

            Assert.AreEqual(expected, actual);
        }
    }
}

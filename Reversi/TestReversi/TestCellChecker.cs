using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reversi;

namespace TestReversi
{
    [TestClass]
    
    public class TestCellChecker
    {
        [TestMethod]
        
        public void TestCheckCell()
        {
            Chip[,] testBoard = new Chip[8, 8];
            Chip WhiteChip1 = new Chip {color=1};
            Chip WhiteChip2 = new Chip { color = 1 };
            Chip BlackChip1 = new Chip { color = 2 };
            Chip BlackChip2 = new Chip { color = 2 };
            testBoard[4, 4] = WhiteChip1;
            testBoard[5, 5] = WhiteChip2;
            testBoard[4, 5] = BlackChip1;
            testBoard[5, 4] = BlackChip2;
            var CellCheckerForTest=new CellChecker();
            //TODO
            bool expected = true;
            
            bool testCheckCell1 = CellCheckerForTest.CheckCell(1, 4, 6);

            Assert.AreEqual(expected, testCheckCell1);
            
        }


    }
}

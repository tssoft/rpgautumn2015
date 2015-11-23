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
            
            bool testCheckCell1 = CellCheckerForTest.CheckCell(1, 4, 6);
            bool testCheckCell2 = CellCheckerForTest.CheckCell(1, 6, 4);
            bool testCheckCell3 = CellCheckerForTest.CheckCell(1, 3, 5);
            bool testCheckCell4 = CellCheckerForTest.CheckCell(1, 5, 3);
            bool testCheckCell5 = CellCheckerForTest.CheckCell(1, 4, 3);
            bool testCheckCell6 = CellCheckerForTest.CheckCell(1, 5, 6);
            
            if ((testCheckCell1 && testCheckCell2 && testCheckCell3 && testCheckCell4)
                &&(!testCheckCell5 && !testCheckCell6))
            {
                Console.WriteLine("Test is complited");
            }
            else
            {
                Console.WriteLine("Test is not complited");
            }
        }
    }
}

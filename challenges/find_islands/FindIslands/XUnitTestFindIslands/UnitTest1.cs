using System;
using Xunit;
using Find_Islands;
using static Find_Islands.Program;

namespace XUnitTestFindIslands
{
    public class UnitTest1
    {
        [Fact]
        public void CanCountIslands()
        {

            int[,] datArray1 = new int[,]
            {
                {0, 0, 0, 0 },
                {0, 0, 0, 0 },
                {0, 0, 0, 0 },
                {0, 0, 0, 0 }
            };

            int numIslands1 = FindIslands(datArray1);

            int[,] datArray2 = new int[,]
            {
                {0, 1, 1, 0, 0, 0},
                {1, 0, 1, 1, 0, 0},
                {1, 1, 0, 0, 0, 0},
                {0, 1, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 1},
                {0, 0, 0, 0, 1, 0}
            };

            int numIslands2 = FindIslands(datArray2);

            int[,] datArray3 = new int[,]
            {
                    { 0, 0, 0, 0, 0, 1},
                    { 0, 0, 0, 0, 0, 1},
                    { 0, 0, 0, 0, 0, 1},
                    { 0, 0, 0, 0, 0, 1},
                    { 0, 0, 0, 0, 0, 1},
                    { 1, 1, 1, 1, 1, 0},
            };

            int numIslands3 = FindIslands(datArray3);

            int[,] datArray4 = new int[,]
            {
                {0, 1, 1, 1 },
                {1, 0, 1, 1 },
                {1, 1, 0, 1 },
                {1, 1, 1, 0 }
            };

            int numIslands4 = FindIslands(datArray4);

            Assert.Equal(4, numIslands1);
            Assert.Equal(2, numIslands2);
            Assert.Equal(1, numIslands3);
            Assert.Equal(1, numIslands4);
        }
    }
}

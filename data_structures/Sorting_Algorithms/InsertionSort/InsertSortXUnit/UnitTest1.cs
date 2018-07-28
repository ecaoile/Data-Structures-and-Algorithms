using System;
using Xunit;
using static InsertionSortImplement.Program;

namespace InsertSortXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortUnsortedArray()
        {
            int[] datArray1 = new int[] { 6, 7, 5, 4, 3 };

            InsertionSort(datArray1, datArray1.Length - 1);

            Assert.Equal(3, datArray1[0]);
            Assert.Equal(4, datArray1[1]);
            Assert.Equal(5, datArray1[2]);
            Assert.Equal(6, datArray1[3]);
            Assert.Equal(7, datArray1[4]);
        }

        [Fact]
        public void CanMaintainAlreadySortedArray()
        {
            int[] datArray1 = new int[] { 7, 8, 9, 10, 11 };
            Assert.Equal(7, datArray1[0]);
            Assert.Equal(8, datArray1[1]);
            Assert.Equal(9, datArray1[2]);
            Assert.Equal(10, datArray1[3]);
            Assert.Equal(11, datArray1[4]);
        }

        [Fact]
        public void CanKeepArrayWithOneValue()
        {
            int[] datArray1 = new int[] { 7 };
            InsertionSort(datArray1, datArray1.Length - 1);

            Assert.Equal(7, datArray1[0]);
        }

        [Fact]
        public void CanSortNegativeValue()
        {
            int[] datArray1 = new int[] { -3, -4, 1, -2, 0 };
            InsertionSort(datArray1, datArray1.Length - 1);

            Assert.Equal(-4, datArray1[0]);
            Assert.Equal(-3, datArray1[1]);
            Assert.Equal(-2, datArray1[2]);
            Assert.Equal(0, datArray1[3]);
            Assert.Equal(1, datArray1[4]);
        }
    }
}

using System;
using Xunit;
using static Quick_Sort.Program;

namespace XUnitQuickSort
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] {34, 19, 42, -9, 2018, 0, 2005, 77, 2099}, new int[] {-9, 0, 19, 34, 42, 77, 2005, 2018, 2099})]
        [InlineData((new int[] { 3, 5, 1, 8, 7 }), (new int[] { 1, 3, 5, 7, 8 }))]
        [InlineData((new int[] { 4, 11, 5, 0, -1, 3 }), (new int[] { -1, 0, 3, 4, 5, 11 }))]
        [InlineData((new int[] { 1, -1, 0 }), (new int[] { -1, 0, 1 }))]
        public void CanArrangeUnsortedArray(int[] input, int[] output)
        {
            Assert.Equal(output, QuickSort(input, 0, input.Length - 1));
        }

        [Theory]
        [InlineData((new int[] { 0 }), (new int[] { 0 }))]
        [InlineData((new int[] { -1, 0, 1 }), (new int[] { -1, 0, 1 }))]
        [InlineData((new int[] { -10, 2, 3, 7 }), (new int[] { -10, 2, 3, 7 }))]
        public void CanMaintainAlreadySortedArray(int[] input, int[] output)
        {
            Assert.Equal(output, QuickSort(input, 0, input.Length - 1));
        }
    }
}

using System;
using Xunit;
using static Merge_Sort.Program;
namespace XUnitMergeSort
{
    public class UnitTest1
    {
        [Theory]
        [InlineData((new int[] { 3, 5, 1, 8, 7 }), (new int[] { 1, 3, 5, 7, 8 }))]
        [InlineData((new int[] { 4, 11, 5, 0, -1, 3 }), (new int[] { -1, 0, 3, 4, 5, 11 }))]
        [InlineData((new int[] { 1, -1, 0 }), (new int[] { -1, 0, 1}))]
        public void CanArrangeUnsortedArray(int[] input, int[] output)
        {
            Assert.Equal(output, MergeSort(input, 0, input.Length - 1));
        }

        [Theory]
        [InlineData((new int[] { 0 }), (new int[] { 0 }))]
        [InlineData((new int[] { -1, 0, 1 }), (new int[] { -1, 0, 1 }))]
        [InlineData((new int[] { -10, 2, 3, 7 }), (new int[] { -10, 2, 3, 7 }))]
        public void CanMaintainAlreadySortedArray(int[] input, int[] output)
        {
            Assert.Equal(output, MergeSort(input, 0, input.Length - 1));
        }
    }
}

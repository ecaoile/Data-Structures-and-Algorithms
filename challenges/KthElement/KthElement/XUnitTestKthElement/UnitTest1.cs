using System;
using Xunit;
using KthElement;
using static KthElement.Program;
using KthElement.Classes;

namespace XUnitTestKthElement
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 42)]
        [InlineData(1, 24)]
        [InlineData(2, 12)]
        public void CanReturnValidNode(int k, int expectedValue)
        {
            Assert.Equal(expectedValue, Program.KthElement(k).Value);
        }

        [Fact]
        public void CanReturnNullforOutOfIndex()
        {
            int k = 555;
            Assert.Null(Program.KthElement(k));
        }
    }
}

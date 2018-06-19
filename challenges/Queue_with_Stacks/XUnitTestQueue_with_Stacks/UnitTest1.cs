using System;
using Xunit;
using Queue_with_Stacks;
using static Queue_with_Stacks.Program;
using Queue_with_Stacks.Classes;

namespace XUnitTestQueue_with_Stacks
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnqueue()
        {
            Stack stack1 = new Stack(new Node(20));
            Assert.Equal(15, stack1.Enqueue(15).Value);
            Assert.Equal(10, stack1.Enqueue(10).Value);
            Assert.Equal(5, stack1.Enqueue(5).Value);
        }

        [Fact]
        public void CanDequeue()
        {
            Stack stack1 = new Stack(new Node(20));
            stack1.Push(new Node(15));
            stack1.Push(new Node(10));
            Assert.Equal(20, stack1.Dequeue().Value);
            Assert.Equal(15, stack1.Dequeue().Value);
            Assert.Equal(10, stack1.Dequeue().Value);
        }
    }
}

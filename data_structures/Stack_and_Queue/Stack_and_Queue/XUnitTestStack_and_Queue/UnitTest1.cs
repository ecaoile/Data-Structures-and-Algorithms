using System;
using Xunit;
using Stack_and_Queue;
using static Stack_and_Queue.Program;
using Stack_and_Queue.Classes;

namespace XUnitTestStack_and_Queue
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushStack()
        {
            Stack testStack = new Stack(new Node(7));

            Console.WriteLine("\nNow let's add a few nodes!");
            Assert.Equal(14, testStack.Push(new Node(14)).Value);
            Assert.Equal(20, testStack.Push(new Node(20)).Value);
            Assert.Equal(42, testStack.Push(new Node(42)).Value);
        }

        [Fact]
        public void CanPopStack()
        {
            Stack testStack = new Stack(new Node(7));
            testStack.Push(new Node(14));
            testStack.Push(new Node(20));
            testStack.Push(new Node(42));

            Assert.Equal(42, testStack.Pop().Value);
            Assert.Equal(20, testStack.Pop().Value);
            Assert.Equal(14, testStack.Pop().Value);
        }

        [Fact]
        public void CanPeekStack()
        {
            Stack testStack = new Stack(new Node(7));
            testStack.Push(new Node(14));
            testStack.Push(new Node(20));
            testStack.Push(new Node(42));
            Assert.Equal(42, testStack.Peek().Value);

            testStack.Pop();
            Assert.Equal(20, testStack.Peek().Value);

            testStack.Pop();
            Assert.Equal(14, testStack.Peek().Value);
        }

        [Fact]
        public void CanEnqueue()
        {
            Queue testQueue = new Queue(new Node(5));
            Assert.Equal(10, testQueue.Enqueue(new Node(10)).Value);
            Assert.Equal(20, testQueue.Enqueue(new Node(20)).Value);
            Assert.Equal(30, testQueue.Enqueue(new Node(30)).Value);
        }

        [Fact]
        public void CanDequeue()
        {
            Queue testQueue = new Queue(new Node(5));
            testQueue.Enqueue(new Node(10));
            testQueue.Enqueue(new Node(20));
            testQueue.Enqueue(new Node(30));

            Assert.Equal(5, testQueue.Dequeue().Value);
            Assert.Equal(10, testQueue.Dequeue().Value);
            Assert.Equal(20, testQueue.Dequeue().Value);
        }

        [Fact]
        public void CanPeekQueue()
        {
            Queue testQueue = new Queue(new Node(5));
            testQueue.Enqueue(new Node(10));
            testQueue.Enqueue(new Node(20));
            testQueue.Enqueue(new Node(30));

            Assert.Equal(5, testQueue.Peek().Value);

            testQueue.Dequeue();
            Assert.Equal(10, testQueue.Peek().Value);

            testQueue.Dequeue();
            Assert.Equal(20, testQueue.Peek().Value);
        }
    }
}

using System;
using Xunit;
using ll_merge;
using static ll_merge.Program;
using ll_merge.Classes;

namespace XUnitTest_ll_merge
{
    public class UnitTest1
    {
        [Fact]
        public void CanMergeLLsWtihSameLengths()
        {
            SinglyLinkedList ll1 = new SinglyLinkedList(new Node(1));
            ll1.AddLast(new Node(3));
            ll1.AddLast(new Node(2));

            SinglyLinkedList ll2 = new SinglyLinkedList(new Node(5));
            ll2.AddLast(new Node(9));
            ll2.AddLast(new Node(4));

            SinglyLinkedList ll3 = Merge(ll1, ll2);

            Assert.Equal(ll1.Head.Value, ll3.Head.Value);
            Assert.Equal(2, ll3.Find(2).Value);
            Assert.Equal(4, ll3.Find(4).Value);
            Assert.Equal(3, ll3.Find(3).Value);
            Assert.Equal(9, ll3.Find(9).Value);
            Assert.Equal(5, ll3.Find(5).Value);
            Assert.Equal(1, ll3.Find(1).Value);
        }

        [Fact]
        public void CanMergeLLsWithDiffLengths()
        {
            SinglyLinkedList ll1 = new SinglyLinkedList(new Node(1));
            ll1.AddLast(new Node(3));

            SinglyLinkedList ll2 = new SinglyLinkedList(new Node(5));
            ll2.AddLast(new Node(9));
            ll2.AddLast(new Node(4));
            ll2.AddLast(new Node(2));

            SinglyLinkedList ll3 = Merge(ll1, ll2);

            Assert.Equal(ll1.Head.Value, ll3.Head.Value);
            Assert.Equal(2, ll3.Find(2).Value);
            Assert.Equal(4, ll3.Find(4).Value);
            Assert.Equal(3, ll3.Find(3).Value);
            Assert.Equal(9, ll3.Find(9).Value);
            Assert.Equal(5, ll3.Find(5).Value);
            Assert.Equal(1, ll3.Find(1).Value);
        }
    }
}

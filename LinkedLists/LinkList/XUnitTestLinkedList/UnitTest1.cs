using System;
using Xunit;
using LinkList;
using static LinkList.Program;

namespace XUnitTestLinkedList
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNode()
        {
            // Arrange
            SinglyLinkedList ll = new SinglyLinkedList(new Node(4));
            Node node = new Node(8);
            Node node2 = new Node(15);
        }
    }
}

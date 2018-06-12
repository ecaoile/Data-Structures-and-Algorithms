using System;
using Xunit;
using LinkList;

namespace XUnitTestLinkedList
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNode()
        {
            // Arrange
            SinglyLinkedList ll = new SinglyLinkedList(new Node(4));
            Node node1 = new Node(8);
            Node node2 = new Node(15);

            // Acdt
            ll.Add(node1);
            ll.Add(node2);

            // 4 -> 8 -> 15

            Assert.Equal(ll.Head.Value, node2.Value);
        }

        [Theory]
        [InlineData(8, 8)]
        [InlineData(24, 24)]
        public void CanFindNodeThatExists(int value, int expectedValue)
        {
            // Arrange
            SinglyLinkedList ll = new SinglyLinkedList(new Node(4));
            Node node1 = new Node(8);
            Node node2 = new Node(15);
            Node node3 = new Node(24);
            Node node4 = new Node(36);

            // Add
            ll.Add(node1);
            ll.Add(node2);
            ll.Add(node3);
            ll.Add(node4);

            // Act
            Node found = ll.Find(value);

            // Assert
            Assert.Equal(expectedValue, found.Value);
        }

        [Theory]
        [InlineData(42)]
        [InlineData(555)]
        public void ReturnsNullForNonExistentNode(int value)
        {
            // Arrange
            SinglyLinkedList ll = new SinglyLinkedList(new Node(4));
            Node node1 = new Node(8);
            Node node2 = new Node(15);
            Node node3 = new Node(24);
            Node node4 = new Node(36);

            // Add
            ll.Add(node1);
            ll.Add(node2);
            ll.Add(node3);
            ll.Add(node4);

            // Act
            Node found = ll.Find(value);

            // Assert
            Assert.Null(found);
        }
    }
}

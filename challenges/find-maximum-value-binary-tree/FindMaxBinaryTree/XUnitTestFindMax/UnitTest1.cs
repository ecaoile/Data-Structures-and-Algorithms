using System;
using Xunit;
using FindMaxBinaryTree.Classes;

namespace XUnitTestFindMax
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindMaxInTreeWithPositivesOnly()
        {
            Node datRoot = new Node(2);
            BinaryTree datTree = new BinaryTree(datRoot);
            datTree.Root.LeftChild = new Node(7);
            datTree.Root.LeftChild.LeftChild = new Node(2);
            datTree.Root.LeftChild.RightChild = new Node(6);
            datTree.Root.LeftChild.RightChild.LeftChild = new Node(5);
            datTree.Root.LeftChild.RightChild.RightChild = new Node(11);
            datTree.Root.RightChild = new Node(5);
            datTree.Root.RightChild.RightChild = new Node(9);
            datTree.Root.RightChild.RightChild.LeftChild = new Node(4);
            Assert.Equal(11, datTree.FindMax(datRoot));
        }

        [Fact]
        public void CanFindMaxInTreeWithNegativeValues()
        {
            Node datRoot = new Node(2);
            BinaryTree datTree = new BinaryTree(datRoot);
            datTree.Root.LeftChild = new Node(-11);
            datTree.Root.LeftChild.LeftChild = new Node(2.3241234);
            datTree.Root.LeftChild.RightChild = new Node(3.12341234);
            datTree.Root.LeftChild.RightChild.LeftChild = new Node(12424);
            datTree.Root.LeftChild.RightChild.RightChild = new Node(0);
            datTree.Root.RightChild = new Node(3);
            datTree.Root.RightChild.RightChild = new Node(9);
            datTree.Root.RightChild.RightChild.LeftChild = new Node(4);
            Assert.Equal(12424, datTree.FindMax(datRoot));
        }

        [Fact]
        public void CanFindMaxInTreeWithOneNode()
        {
            Node datRoot1 = new Node(2);
            BinaryTree datTree1 = new BinaryTree(datRoot1);
            Assert.Equal(2, datTree1.FindMax(datRoot1));

            Node datRoot2 = new Node(-1.34);
            BinaryTree datTree2 = new BinaryTree(datRoot2);
            Assert.Equal(-1.34, datTree1.FindMax(datRoot2));
        }
    }
}

using System;
using Xunit;
using BT_and_BST;
using BT_and_BST.Classes;
using static BT_and_BST.Program;

namespace XUnitTestBT_and_BST
{
    public class UnitTest1
    {

        [Fact]
        public void CanAddNodeToBST()
        {
            BinarySearchTree datBST = new BinarySearchTree(new Node(100));
            Assert.True(datBST.Add(datBST.Root, 200));
            Assert.True(datBST.Add(datBST.Root, 25));
            Assert.True(datBST.Add(datBST.Root, 75));
            Assert.True(datBST.Add(datBST.Root, 50));
            Assert.False(datBST.Add(datBST.Root, 200));
            Assert.False(datBST.Add(datBST.Root, 25));
            Assert.False(datBST.Add(datBST.Root, 75));
            Assert.False(datBST.Add(datBST.Root, 50)); 
        }

        [Fact]
        public void CanFindNodeInBST()
        {
            BinarySearchTree datBST = new BinarySearchTree(new Node(100));
            datBST.Add(datBST.Root, 200);
            datBST.Add(datBST.Root, 50);
            datBST.Add(datBST.Root, 25);
            datBST.Add(datBST.Root, 75);
            datBST.Add(datBST.Root, 300);

            Assert.Equal(200, datBST.Search(datBST.Root, 200).Value);
            Assert.Equal(50, datBST.Search(datBST.Root, 50).Value);
            Assert.Equal(300, datBST.Search(datBST.Root, 300).Value);
            Assert.Null(datBST.Search(datBST.Root, 555));
            Assert.Null(datBST.Search(datBST.Root, 42));
            Assert.Null(datBST.Search(datBST.Root, 1337));
        }

        [Fact]
        public void CanFindNodeInBinaryTree()
        {
            Node datRoot = new Node(3);
            BinaryTree datBT = new BinaryTree(datRoot);
            datBT.Add(datRoot, 5);
            datBT.Add(datRoot, 7);
            datBT.Add(datRoot, 10);
            datBT.Add(datRoot, 13);
            datBT.Add(datRoot, 15);

            Assert.Equal(10, datBT.Search(datBT.Root, 10).Value);
            Assert.Equal(5, datBT.Search(datBT.Root, 5).Value);
            Assert.Equal(7, datBT.Search(datBT.Root, 7).Value);
            Assert.Null(datBT.Search(datBT.Root, 555));
            Assert.Null(datBT.Search(datBT.Root, 42));
            Assert.Null(datBT.Search(datBT.Root, 1337));
        }
    }
}

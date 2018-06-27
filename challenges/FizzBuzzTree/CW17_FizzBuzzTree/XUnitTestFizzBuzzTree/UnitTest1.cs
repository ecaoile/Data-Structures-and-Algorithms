using System;
using Xunit;
using CW17_FizzBuzzTree.Classes;

namespace XUnitTestFizzBuzzTree
{
    public class UnitTest1
    {
        [Fact]
        public void CanDoFizzBuzzOnTree()
        {
            Node datRoot = new Node("5");
            Tree datTree = new Tree(datRoot);
            datTree.Root.LeftChild = new Node("3");
            datTree.Root.RightChild = new Node("15");
            datTree.Root.LeftChild.LeftChild = new Node("7");
            datTree.Root.LeftChild.RightChild = new Node("1");
            datTree.Root.RightChild.RightChild = new Node("not a number");

            datTree.FizzBuzzTree(datRoot);
            Assert.Equal("buzz", datTree.Root.Value);
            Assert.Equal("fizz", datTree.Root.LeftChild.Value);
            Assert.Equal("fizzbuzz", datTree.Root.RightChild.Value);
            Assert.Equal("7", datTree.Root.LeftChild.LeftChild.Value);
            Assert.Equal("1", datTree.Root.LeftChild.RightChild.Value);
            Assert.Equal("not a number", datTree.Root.RightChild.RightChild.Value);
        }
    }
}

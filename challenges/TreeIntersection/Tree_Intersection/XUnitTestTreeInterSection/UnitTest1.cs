using System;
using Xunit;
using static Tree_Intersection.Program;
using Tree_Intersection.Classes;
using System.Collections.Generic;

namespace XUnitTestTreeInterSection
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindCommonValues()
        {
            Node datBST1Root = new Node(150);
            BinarySearchTree datBST1 = new BinarySearchTree(datBST1Root);
            datBST1.Add(datBST1Root, 100);
            datBST1.Add(datBST1Root, 250);
            datBST1.Add(datBST1Root, 75);
            datBST1.Add(datBST1Root, 200);
            datBST1.Add(datBST1Root, 350);
            datBST1.Add(datBST1Root, 125);
            datBST1.Add(datBST1Root, 300);
            datBST1.Add(datBST1Root, 500);

            List<int> datNumList1 = datBST1.BreadthFirstList(datBST1Root);

            Node datBST2Root = new Node(42);
            BinarySearchTree datBST2 = new BinarySearchTree(datBST2Root);
            datBST2.Add(datBST2Root, 100);
            datBST2.Add(datBST2Root, 600);
            datBST2.Add(datBST2Root, 4);
            datBST2.Add(datBST2Root, 15);
            datBST2.Add(datBST2Root, 160);
            datBST2.Add(datBST2Root, 175);
            datBST2.Add(datBST2Root, 200);
            datBST2.Add(datBST2Root, 300);

            bool has200 = TreeIntersection(datBST1, datBST2).Contains(200);
            bool has100 = TreeIntersection(datBST1, datBST2).Contains(100);
            bool has300 = TreeIntersection(datBST2, datBST2).Contains(300);

            bool has4 = TreeIntersection(datBST1, datBST2).Contains(4);
            bool has42 = TreeIntersection(datBST1, datBST2).Contains(42);
            bool has160 = TreeIntersection(datBST1, datBST2).Contains(160);

            Assert.True(has200);
            Assert.True(has100);
            Assert.True(has300);
            Assert.False(has4);
            Assert.False(has42);
            Assert.False(has160);
        }

        [Fact]
        public void CanFindFromIdenticalTrees()
        {
            Node datBST1Root = new Node(150);
            BinarySearchTree datBST1 = new BinarySearchTree(datBST1Root);
            datBST1.Add(datBST1Root, 100);
            datBST1.Add(datBST1Root, 250);
            datBST1.Add(datBST1Root, 75);
            datBST1.Add(datBST1Root, 200);
            datBST1.Add(datBST1Root, 125);


            List<int> datNumList1 = datBST1.BreadthFirstList(datBST1Root);

            Node datBST2Root = new Node(150);
            BinarySearchTree datBST2 = new BinarySearchTree(datBST2Root);
            datBST2.Add(datBST2Root, 100);
            datBST2.Add(datBST2Root, 250);
            datBST2.Add(datBST2Root, 75);
            datBST2.Add(datBST2Root, 200);
            datBST2.Add(datBST2Root, 125);


            List<int> datNumList2 = datBST2.BreadthFirstList(datBST2Root);

            List<int> datIntersection = TreeIntersection(datBST1, datBST2);

            Assert.Equal(datNumList1, datIntersection);
            Assert.Equal(datNumList2, datIntersection);
        }

        [Fact]
        public void CanReturnNoCommonValues()
        {
            Node datBST1Root = new Node(4);
            BinarySearchTree datBST1 = new BinarySearchTree(datBST1Root);
            datBST1.Add(datBST1Root, 2);
            datBST1.Add(datBST1Root, 3);
            datBST1.Add(datBST1Root, 6);
            datBST1.Add(datBST1Root, 5);
            datBST1.Add(datBST1Root, 1);

            List<int> datNumList1 = datBST1.BreadthFirstList(datBST1Root);

            Node datBST2Root = new Node(7);
            BinarySearchTree datBST2 = new BinarySearchTree(datBST2Root);
            datBST2.Add(datBST2Root, 9);
            datBST2.Add(datBST2Root, 11);
            datBST2.Add(datBST2Root, 12);
            datBST2.Add(datBST2Root, 8);
            datBST2.Add(datBST2Root, 10);

            List<int> datNumList2 = datBST2.BreadthFirstList(datBST2Root);

            List<int> datIntersection = TreeIntersection(datBST1, datBST2);
            Assert.Empty(datIntersection);
        }
    }
}

using System;
using Xunit;
using static Hashtables.Program;
using Hashtables.Classes;

namespace XUnitTestHashtables
{
    public class UnitTest1
    {
        /// <summary>
        /// tests the following: 1. Insertion
        /// </summary>
        [Fact]
        public void CanAddToHashtable()
        {
            Hashtable datHashTable = new Hashtable(1024);
            Node node1 = datHashTable.Add("cat", 42);
            Node node2 = datHashTable.Add("dog", 555);
            Node node3 = datHashTable.Add("supercalifragilisticexpialidocious",
                1111);
            Node node4 = datHashTable.Add("Mississippi", 333);

            Assert.Equal(42, datHashTable.Find("cat"));
            Assert.Equal(555, datHashTable.Find("dog"));
            Assert.Equal(1111, datHashTable.Find("supercalifragilisticexpialidocious"));
            Assert.Equal(333, datHashTable.Find("Mississippi"));
        }

        /// <summary>
        /// tests the following: 2. Contains
        /// </summary>
        [Fact]
        public void HashTableCanContain()
        {
            Hashtable datHashTable = new Hashtable(1024);
            Node node1 = datHashTable.Add("cat", 42);
            Node node2 = datHashTable.Add("dog", 555);
            Node node3 = datHashTable.Add("supercalifragilisticexpialidocious",
                1111);
            Node node4 = datHashTable.Add("Mississippi", 333);

            Assert.True(datHashTable.Contains("cat"));
            Assert.True(datHashTable.Contains("dog"));
            Assert.True(datHashTable.Contains("supercalifragilisticexpialidocious"));
            Assert.True(datHashTable.Contains("Mississippi"));
            Assert.False(datHashTable.Contains("Bob"));
        }

        /// <summary>
        /// tests the following: 3. collisions
        /// </summary>
        [Fact]
        public void CanDealWithCollisionsSameChars()
        {
            Hashtable datHashTable = new Hashtable(1024);
            Node node1 = datHashTable.Add("cat", 42);
            Node node2 = datHashTable.Add("act", 555);
            Node node3 = datHashTable.Add("dog",
                1111);
            Node node4 = datHashTable.Add("god", 777);

            Assert.Equal(42, datHashTable.Find("cat"));
            Assert.Equal(555, datHashTable.Find("act"));
            Assert.Equal(1111, datHashTable.Find("dog"));
            Assert.Equal(777, datHashTable.Find("god"));
        }

        /// <summary>
        /// tests the following: 3. collisions
        /// </summary>
        [Fact]
        public void CanDealWithCollisionsSameASCIITotal()
        {
            Hashtable datHashTable = new Hashtable(1024);
            Node node1 = datHashTable.Add("Cat", 42);
            Node node2 = datHashTable.Add("Doe", 555);
            Node node3 = datHashTable.Add("fat",
                1111);
            Node node4 = datHashTable.Add("gas", 777);

            Assert.Equal(42, datHashTable.Find("Cat"));
            Assert.Equal(555, datHashTable.Find("Doe"));
            Assert.Equal(1111, datHashTable.Find("fat"));
            Assert.Equal(777, datHashTable.Find("gas"));
        }
    }
}   

using System;
using Xunit;
using static Hashtables.Program;
using Hashtables.Classes;

namespace XUnitTestHashtables
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddToHashtable()
        {
            Hashtable datHashTable = new Hashtable(1024);
            Assert.IsType<Node>(datHashTable.Add("cat", 42));
            Assert.IsType<Node>(datHashTable.Add("dog", 555));
            Assert.IsType<Node>(datHashTable.Add("supercalifragilisticexpialidocious",
                1111));
            Node node4 = datHashTable.Add("Mississippi", 777);
        }
    }
}

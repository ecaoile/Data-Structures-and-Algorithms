using System;
using Xunit;
using Left_Join.Classes;
using static Left_Join.Program;
using System.Collections.Generic;

namespace XUnitTestLeftJoin
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            HashMap datHM1 = new HashMap(1024);
            datHM1.Add("fond", "enamored");
            datHM1.Add("wrath", "angered");
            datHM1.Add("diligent", "employed");
            datHM1.Add("outfit", "garb");
            datHM1.Add("guide", "usher");

            HashMap datHM2 = new HashMap(1024);
            datHM2.Add("fond", "averse");
            datHM2.Add("wrath", "delight");
            datHM2.Add("diligent", "idle");
            datHM2.Add("guide", "follow");
            datHM2.Add("flow", "jam");

            List<List<string>> datListOfLists = LeftJoin(datHM1, datHM2);
            bool containsDelight = false;
            bool containsIdle = false;
            bool containsFollow = false;
            bool containsFlow = false;
            bool containsJam = false;

            foreach (var list in datListOfLists)
            {
                if (list.Contains("delight"))
                    containsDelight = true;

                if (list.Contains("idle"))
                    containsIdle = true;

                if (list.Contains("follow"))
                    containsFollow = true;

                if (list.Contains("flow"))
                    containsFlow = true;

                if (list.Contains("jam"))
                    containsJam = true;
            }

            Assert.True(containsDelight);
            Assert.True(containsIdle);
            Assert.True(containsFollow);
            Assert.False(containsFlow);
            Assert.False(containsJam);
        }
    }
}

using System;
using Xunit;
using static Repeated_Word.Program;
using Repeated_Word.Classes;

namespace XUnitTestRepeatedWord
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindRepeatedWord()
        {
            string datString1 = "I like bacon, eggs, and bacon again!";
            string foundString1 = RepeatedWord(datString1);

            string datString2 = "eggs bacon sausage eggs bacon sausage";
            string foundString2 = RepeatedWord(datString2);

            string datString3 = "There are no duplicates.";
            string foundString3 = RepeatedWord(datString3);

            string datString4 = "Once upon a time, there was a brave princess who...";
            string foundString4 = RepeatedWord(datString4);

            string datString5 = "It was the best of times, it was the worst of times, it was the age of wisdom, " +
                "it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was " +
                "the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of " +
                "despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, " +
                "we were all going direct the other way – in short, the period was so far like the present period, that" +
                " some of its noisiest authorities insisted on its being received, for good or for evil, in the " +
                "superlative degree of comparison only...";
            string foundString5 = RepeatedWord(datString5);

            Assert.Equal("bacon", foundString1);
            Assert.Equal("eggs", foundString2);
            Assert.Null(foundString3);
            Assert.Equal("a", foundString4);
            Assert.Equal("it", foundString5);
        }
    }
}

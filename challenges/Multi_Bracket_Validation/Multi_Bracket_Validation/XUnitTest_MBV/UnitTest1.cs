using System;
using Xunit;
using Multi_Bracket_Validation;
using static Multi_Bracket_Validation.Program;

namespace XUnitTest_MBV
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{}")]
        [InlineData("{}(){}")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("(){}[[]]")]
        [InlineData("{}{Code}[Fellows](())")]
        public void CanReturnTrueforValidStrings(string input)
        {
            Assert.True(MultiBracketValidation(input));
        }

        [Theory]
        [InlineData("[({}]")]
        [InlineData("(](")]
        [InlineData("({)}")]
        [InlineData(")(")]
        [InlineData("{})(")]
        public void CanReturnFalseforInvalidStrings(string input)
        {
            Assert.False(MultiBracketValidation(input));
        }
    }
}

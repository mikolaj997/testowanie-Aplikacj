using System;
using Xunit;
using TestowanieAplikacj;
namespace testowanieAplikacjiTests
{
    public class averigeTests
    {
        [Fact]
        public void averigeScore_Return_expectedValue()
        {
            var averige = new averige();

            var result = averige.averigeScore(2,2,2,2);

            Assert.Equal(2, result);
        } 
    }
}


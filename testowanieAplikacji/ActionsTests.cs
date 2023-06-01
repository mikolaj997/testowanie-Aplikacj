
using System;
using Xunit;
using TestowanieAplikacj;

namespace testowanieAplikacjiTests
{
    public class ActionsTests
    {
        [Fact]
        public void Multiply_IsCorrect_returnTrue()
        {
            var math2 = new Actions();

            var result = math2.Multiply(5, 5);

            Assert.Equal(25, result);

        }
    }
}
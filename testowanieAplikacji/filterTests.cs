using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestowanieAplikacj;
using Xunit;

namespace testowanieAplikacjiTests
{
    public class filterTests
    {
        [Fact]
        public void Filter_Should_Return_Only_Even_Numbers()
        {
            filter f = new filter();
            List<int> input = new List<int> { 1, 2, 2, 3, 5, 7, 9, 8, 2 };
            List<int> expectedOutput = new List<int> { 2, 2, 8, 2 };

            List<int> actualOutput = f.Filter(input);

            Assert.Equal(expectedOutput, actualOutput);
        }

    }
}


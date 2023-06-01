using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using TestowanieAplikacj;

namespace testowanieAplikacjiTests
{
    public class NWDTests
    {

        [Fact]
        public void FindNWD_ReturnsCorrectResult()
        {
            int n = 24;
            int m = 18;
            int expectedNWD = 6;

            int actualNWD =  NWD.FindNWD(n, m);

            Assert.Equal(expectedNWD, actualNWD);
        }

        
    }
}

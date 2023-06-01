using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestowanieAplikacj;

namespace testowanieAplikacjiTests
{

    public class TenisTrophyInfoTests
    {
        [Theory]
        [InlineData(0, "adverage player")]
        [InlineData(1, "good player")]
        [InlineData(5, "experience player")]
        [InlineData(10, "Extremly good player")]
        public void TrophyCountInfo_ShouldReturnCorrectMessage(double trophy, string expectedMessage)
        { 
            var tenisTrophyInfo = new TenisTrophyInfo();

            var actualMessage = tenisTrophyInfo.TrophyCountInfo(trophy);

            Assert.Equal(expectedMessage, actualMessage);
        }
    }

}

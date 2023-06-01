using System;
using TestowanieAplikacj;
using Xunit;

namespace testowanieAplikacjiTests
{
    public class DateTest
    {
        
        [Fact]
        public void SchaduledDate_return_CorrectFormat()
        {
                var date = new date();


                var act = date.CurrentDate();

                Assert.Equal(2016, act.Year);
                Assert.Equal(8, act.Month);
                Assert.Equal(16, act.Day);
                Assert.Equal(3, act.Hour);
                Assert.Equal(57, act.Minute);
                Assert.Equal(32, act.Second);
                Assert.Equal(11, act.Millisecond);

        }
    }
}


using System;
using TestowanieAplikacj;
using Xunit;

namespace testowanieAplikacjiTests
{
    public class dominanta1Tests
    {

        [Fact]
        public void dominanta1_ShouldReturnMostFrequentNumber()
        {
            var dominanta = new dominanta1();

            var result = dominanta.FindDominanta(new[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 });

            Assert.Equal(4, result);
        }

        [Fact]
        public void dominanta1_ShouldReturnZeroIfArrayIsEmpty()
        {
            var dominanta = new dominanta1();

            var result = dominanta.FindDominanta(new int[0]);

            Assert.Equal(0, result);
        }

        [Fact]
        public void dominanta1_ShouldReturnNumberIfArrayContainsOnlyOneNumber()
        {
            var dominanta = new dominanta1();

            var result = dominanta.FindDominanta(new[] { 5 });

            Assert.Equal(5, result);
        }
       
    }

}



using System;
using Moq;
using Xunit;
using TestowanieAplikacj;



namespace testowanieAplikacjiTests
{
    public class MockTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            int a = 2;
            int b = 3;
            int expectedSum = 5;

            var calculatorMock = new Mock<IMock>();
            calculatorMock.Setup(calculator => calculator.Add(a, b)).Returns(expectedSum);
            var calculator = calculatorMock.Object;

            int actualSum = calculator.Add(a, b);

            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void Devide_ShouldReturnCorrectSum()
        {
            int c = 2;
            int d = 3;
            int expectedSum = 1;

            var calculatorMock = new Mock<IMock1>();
            calculatorMock.Setup(calculator => calculator.Devide(c, d)).Returns(expectedSum);
            var calculator = calculatorMock.Object;

            int actualSum = calculator.Devide(c, d);

            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void Power_ShouldReturnCorrectSum()
        {
            int d = 2;
            int e = 3;
            int expectedSum = 6;

            var calculatorMock = new Mock<IMock2>();
            calculatorMock.Setup(calculator => calculator.Power(d, e)).Returns(expectedSum);
            var calculator = calculatorMock.Object;

            int actualSum = calculator.Power(d, e);

            Assert.Equal(expectedSum, actualSum);
        }
    }
}


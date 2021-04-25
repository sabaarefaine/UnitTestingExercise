using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 4, 5, 11)]
        [InlineData(4, 6, 7, 17)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act

            var actual = test.Add(num1, num2, num3);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(7, 2, 5)]
        [InlineData(-4, 3, -7)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange

            var test = new UnitTestMethods();

            //Act

            var actual = test.Subtract(minuend, subtrahend);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(7, 3, 21)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange

            var test = new UnitTestMethods();

            //Act

            var actual = test.Multiply(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(15, 5, 3)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange

            var test = new UnitTestMethods();

            //Act

            var actual = test.Divide(num1, num2);

            //Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetHello()
        {
            //Arrange

            var test = new UnitTestMethods();

            //Act

            var actual = test.GetHello();

            //Assert

            Assert.Equal("Hello", actual);

        }

        [Fact]
        public void EvensBelow100()
        {
            //Arrange

            var test = new UnitTestMethods();

            int[] evens =
            {
                2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50,
                52, 54, 56, 58, 60, 62, 64, 66, 68 ,70, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90, 92, 94, 96, 98

            };

            //Act

            int[] actual = test.EvensBelow100();

            //Assert

            Assert.Equal(evens, actual);
        }
    }
}

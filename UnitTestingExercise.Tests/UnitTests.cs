using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(5, 10, 10, 25)]
        [InlineData(8, -7, -8, -7)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test = new Calculator();
            

            //Act
             var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10 , 5, 5)]//Add test data <-------
        [InlineData(8, 5, 3)]
        [InlineData(12, 4, 8)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test1 = new Calculator();

            //Act
            var actual = test1.Subtract(minuend, subtrhend);
            
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(22, 1, 22)]//Add test data <-------
        [InlineData(12, 12, 144)]
        [InlineData(8, 7, 56)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test2 = new Calculator();
            //Act
            var actual = test2.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4, 2, 2)]//Add test data <-------
        [InlineData(8, 2, 4)]
        [InlineData(9, 3, 3)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test3 = new Calculator();
            //Act
            var actual = test3.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}

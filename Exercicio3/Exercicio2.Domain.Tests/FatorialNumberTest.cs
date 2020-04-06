using Bogus;
using Exercicio3.Domain;
using System;
using Xunit;

namespace Exercicio2.Domain.Tests
{
    public class FatorialNumberTest
    {
        [Fact]
        public void Number_FatorialNumberCalculator_FatorialIsCorrect()
        {
            // Arrange 
            var number = new Faker().Random.Int(1, 30);

            // Act
            var _fatorialNumber = new FatorialNumber(number);

            // Assert
            Assert.Equal(number, _fatorialNumber.Number);
        }

        [Fact]
        public void Number_FatorialNumberCalculator_VerifyExceptionNegativeNumbers()
        {
            // Arrange 
            var number = new Faker().Random.Int(-1000, 0);
            var _fatorialNumber = new FatorialNumber(number);

            // Act
            var exception = Assert.Throws<Exception>(() => _fatorialNumber.FatorialNumberCalculator(number));

            // Assert
            Assert.Equal("The number is out of limits!", exception.Message);
        }

        [Fact]
        public void Number_VerifyNumberIsPerfect_VerifyExceptionForValuesGreater30()
        {
            // Arrange 
            var number = new Faker().Random.Int(31, 100);
            var _fatorialNumber = new FatorialNumber(number);

            // Act
            var exception = Assert.Throws<Exception>(() => _fatorialNumber.FatorialNumberCalculator(number));

            // Assert
            Assert.Equal("The number is out of limits!", exception.Message);
        }
    }
}

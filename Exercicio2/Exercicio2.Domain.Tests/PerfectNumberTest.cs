namespace Exercicio2.Domain.Tests
{
    using Bogus;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using Xunit;

    [ExcludeFromCodeCoverage]
    public class PerfectNumberTest
    {
        [Fact]
        public void Number_VerifyNumberIsPerfect_IsPerfectNumber()
        {
            // Arrange 
            var number = new Faker().Random.Int(1, 10000);

            // Act
            var _perfectNumber = new PerfectNumber(number);

            // Assert
            Assert.Equal(number, _perfectNumber.Number);
        }

        [Fact]
        public void Number_VerifyNumberIsPerfect_VerifyExceptionNegativeNumbers()
        {
            // Arrange 
            var number = new Faker().Random.Int(-1000, 0);
            var _perfectNumber = new PerfectNumber(number);

            // Act
            var exception = Assert.Throws<Exception>(() => _perfectNumber.VerifyNumberIsPerfect(number));

            // Assert
            Assert.Equal("The number is out of limits!", exception.Message);
        }

        [Fact]
        public void Number_VerifyNumberIsPerfect_VerifyExceptionForValuesGreater10000()
        {
            // Arrange 
            var number = new Faker().Random.Int(10001, 3000);
            var _perfectNumber = new PerfectNumber(number);

            // Act
            var exception = Assert.Throws<Exception>(() => _perfectNumber.VerifyNumberIsPerfect(number));

            // Assert
            Assert.Equal("The number is out of limits!", exception.Message);
        }
    }
}

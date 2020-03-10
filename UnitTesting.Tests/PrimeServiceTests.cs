using System;
using UnitTesingTut;
using Xunit;

namespace UnitTesting.Tests
{
    public class PrimeServiceTests
    {
        private readonly PrimeService _primeService;
        public PrimeServiceTests()
        {
            _primeService = new PrimeService();
        }

        [Fact]
        public void IsPrime_inputIs1_returnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_inputLessThan2_returnFalse(int value)
        {
            // test -1, 0, 1
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }


        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrime_inputMoreThan2_returnTrue(int value)
        {
            // test 
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }
    }
}

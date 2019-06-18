using System;
using Xunit;
using PrimeService;

namespace PrimeServicesTests
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeServices _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeServices();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void ReturnFalseGivenValuesLessThan2(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

    }
}

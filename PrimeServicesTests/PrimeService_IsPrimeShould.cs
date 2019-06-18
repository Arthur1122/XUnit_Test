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

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(2);

            Assert.False(result, "1 should not be prime");
        }
    }
}

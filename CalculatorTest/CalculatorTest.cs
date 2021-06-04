using CurrencyCalculator;
using System.Collections.Generic;
using Xunit;

namespace CalculatorTest
{
    public class CalculatorTest
    {
        [Fact]
        public void FindLargestAmount_Test()
        {
            Assert.Equal(new Calculator().FindLargestAmount(RetrieveCurrencyData()), "GBP600");
        }

        [Fact]
        public void FindLargestAmount_Different_Currency_Test()
        {
            Assert.Equal(new Calculator().FindLargestAmount(RetrieveCurCodeSpecificData()), "All monies are not in the same currency.");
        }

        [Fact]
        public void CalSumPerCurrency_Test()
        {
            Assert.Equal(new Calculator().CalSumPerCurrency(RetrieveCurCodeSpecificData()), new List<string>() { "GBP1100", "USD1000", "INR900", "EUR500" });
        }

        private IEnumerable<CurrencyDetails> RetrieveCurrencyData()
        {
            return new List<CurrencyDetails>()
            {
                new CurrencyDetails()
                {
                    Amount = 500,
                    Code = CurrencyCode.GBP
                },
                new CurrencyDetails()
                {
                    Amount = 600,
                    Code = CurrencyCode.GBP
                },
                new CurrencyDetails()
                {
                    Amount = 500,
                    Code = CurrencyCode.GBP
                }
            };
        }

        private IEnumerable<CurrencyDetails> RetrieveCurCodeSpecificData()
        {
            return new List<CurrencyDetails>()
            {
                new CurrencyDetails()
                {
                    Amount = 900,
                    Code = CurrencyCode.INR
                },
                new CurrencyDetails()
                {
                    Amount = 1100,
                    Code = CurrencyCode.GBP
                },
                new CurrencyDetails()
                {
                    Amount = 1000,
                    Code = CurrencyCode.USD
                },
                new CurrencyDetails()
                {
                    Amount = 500,
                    Code = CurrencyCode.EUR
                }
            };
        }

    }
}

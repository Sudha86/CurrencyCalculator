using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyCalculator
{
    public class CurrencyDetails
    {
        public CurrencyCode Code { get; set; }

        public decimal Amount { get; set; }
    }

    public enum CurrencyCode
    {
        GBP,
        EUR,
        INR,
        USD
    }
}

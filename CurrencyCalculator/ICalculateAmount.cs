using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyCalculator
{
    public interface ICalculator
    {
        /// <summary>
        /// Logo=ic to find out largest amount.
        /// </summary>
        /// <param name="currencyDetails">currency details.</param>
        /// <returns></returns>
        string FindLargestAmount(IEnumerable<CurrencyDetails> currencyDetails);

        /// <summary>
        /// Logic to calculate sum per currency.
        /// </summary>
        /// <param name="currencyDetails">currency details.</param>
        /// <returns></returns>
        List<string> CalSumPerCurrency(IEnumerable<CurrencyDetails> currencyDetails);
    }
}

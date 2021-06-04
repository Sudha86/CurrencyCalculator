using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CurrencyCalculator
{
    public class Calculator : ICalculator
    {       
        /// <summary>
        /// Logic to calculate sum per currency.
        /// </summary>
        /// <param name="currencyDetails">currency details.</param>
        /// <returns></returns>
        public List<String> CalSumPerCurrency(IEnumerable<CurrencyDetails> currencyDetails)
        {
            var groupedCurrecyDetails = currencyDetails.GroupBy(e => e.Code)
                 .Select(e => new CurrencyDetails
                 {
                     Code = e.Key,
                     Amount = e.Sum(currency=>currency.Amount)
                 }
                 ).OrderByDescending(e=>e.Amount);

            var sumPerCurrency = new List<string>();
            foreach(var currency in groupedCurrecyDetails)
            {
               sumPerCurrency.Add($"{currency.Code}{currency.Amount}");
            }

            return sumPerCurrency;
        }

        /// <summary>
        /// Logo=ic to find out largest amount.
        /// </summary>
        /// <param name="currencyDetails">currency details.</param>
        /// <returns></returns>
        public string FindLargestAmount(IEnumerable<CurrencyDetails> currencyDetails)
        {
            if (currencyDetails.Select(e => e.Code).Distinct().Count() > 1)
            {
                return "All monies are not in the same currency.";
            }
            else
            {
                var largestAmount = currencyDetails.OrderByDescending(e => e.Amount).FirstOrDefault();
                return $"{largestAmount.Code}{largestAmount.Amount}";
            }

        }
    }

}

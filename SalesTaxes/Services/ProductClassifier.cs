using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class ProductClassifier : IClassifier
    {
        /// <summary>
        /// Classify proucts by using hardcode items since we don't have database for mapping
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ProductType ClassifyProducts(string name)
        {
            var food = new[] { "chocolate bar", "chocolates", "chocolate" };
            var medical = new[] { "headache", "pills" };
            name = name.ToLower();

            if (food.Any(name.Contains))
            {
                return ProductType.Food;
            }
            else if (name.Contains("book"))
            {
                return ProductType.Books;
            }
            else if (medical.Any(name.Contains))
            {
                return ProductType.Medical;
            }
            else
            {
                return ProductType.Other;
            }
        }
    }
}

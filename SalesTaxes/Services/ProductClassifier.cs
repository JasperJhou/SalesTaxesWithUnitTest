using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class ProductClassifier : IClassifier
    {
        public ProductType ClassifyProducts(string name)
        {
            var food = new[] { "Chocolate bar", "chocolates"};
            var medical = new[] { "headache", "pills" };
            
            if (food.Any(name.Contains))
            {
                return ProductType.Food;
            }
            else if (name.Contains("Book"))
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

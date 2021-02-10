using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class SalesTaxCalculator : ICalculator
    {
        private readonly BasicSalesTax _basicSalesTax;
        private readonly ImportedSalesTax _importedSalesTax;
        public SalesTaxCalculator()
        {
            _basicSalesTax = new BasicSalesTax();
            _importedSalesTax = new ImportedSalesTax();
        }

        /// <summary>
        /// Calculate products tax based on their tax policy
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public decimal CalculateSalesTax(Product product)
        {
            var tax = 0.0m;
            if (_basicSalesTax.IsApplicable(product))
            {
                tax = _basicSalesTax.Calculate(product);
            }
            if (_importedSalesTax.IsApplicable(product))
            {
                tax = tax + _importedSalesTax.Calculate(product);
            }
            return tax;
        }
    }
}
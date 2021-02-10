using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public abstract class SalesTax
    {
        public abstract decimal Rate { get; }
        public abstract bool IsApplicable(Product item);
        public decimal Calculate(Product product)
        {
            var tax = (product.SalePrice * Rate) / 100;

            tax = Math.Ceiling(tax / 0.05m) * 0.05m;

            return tax;
        }
    }
}


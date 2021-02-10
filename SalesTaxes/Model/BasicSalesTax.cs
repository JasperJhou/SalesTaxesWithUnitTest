using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class BasicSalesTax : SalesTax
    {
        public override decimal Rate { get { return 10.00M; } }
        public override bool IsApplicable(Product product)
        {
            if((product.IsImported && product.ProductType == ProductType.Other) || product.ProductType == ProductType.Other)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

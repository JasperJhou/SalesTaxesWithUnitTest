using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class ImportedSalesTax : SalesTax
    {
        public override decimal Rate { get { return 5.00M; } }

        public override bool IsApplicable(Product product)
        {
            if (product.IsImported)
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

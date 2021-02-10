using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class ShoppingCartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal SaleTax { get; set; }
        public decimal SalePriceWithTax { get { return (SaleTax + Product.SalePrice); } }
    }
}

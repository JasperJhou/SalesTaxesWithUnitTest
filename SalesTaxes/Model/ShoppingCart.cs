using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class ShoppingCart
    {
        public IList<ShoppingCartItem> CartItems { get; set; }
        public decimal TotalSalesTaxes { get { return CartItems.Sum(x => x.SaleTax * x.Quantity); } }
        public decimal TotalSalesPrice { get { return CartItems.Sum(x => x.SalePriceWithTax * x.Quantity); } }
    }
}

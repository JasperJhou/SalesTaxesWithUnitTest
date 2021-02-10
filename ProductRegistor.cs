using System;
using

namespace SalesTaxes
{
    public interface IProductRegistor
    {
        void RegisterProduct(Product product);
    }
    public class ProductRegistor : IProductRegistor
    {
        public decimal CalculateSalesTax(Product product)
        {
            var tax = product.SalePrice * 0.1m / 100;

            tax = Math.Ceiling(tax * 0.05m) / 0.05m;

            return tax;
        }
    }
}

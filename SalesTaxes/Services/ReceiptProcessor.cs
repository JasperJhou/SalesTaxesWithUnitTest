using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class ReceiptProcessor
    {
        private readonly ICalculator _salesTaxCalculator;
        private ShoppingCart _shoppingCart;
        public ReceiptProcessor(ICalculator salesTaxCalculator)
        {
            _salesTaxCalculator = salesTaxCalculator;
            _shoppingCart = new ShoppingCart();
            _shoppingCart.CartItems = new List<ShoppingCartItem>();
        }

        /// <summary>
        /// Convert user inputs into shoppingcart object
        /// </summary>
        /// <param name="itemList"></param>
        /// <returns></returns>
        public ShoppingCart ProcessReceipt(List<string> itemList)
        {
            var itemToAmountMap = new Dictionary<string, int>();
            var productClassifier = new ProductClassifier();
            try
            {
                foreach (string item in itemList)
                {
                    if (itemToAmountMap.ContainsKey(item))
                    {
                        itemToAmountMap[item] = itemToAmountMap[item] + 1;
                    }
                    else
                    {
                        itemToAmountMap.Add(item, 1);
                    }
                }

                foreach (KeyValuePair<string, int> itemToAmount in itemToAmountMap)
                {
                    var item = itemToAmount.Key.Split(' ');
                    var product = new Product
                    {
                        Name = Utility.GetProductName(item),
                        SalePrice = Convert.ToDecimal(item[item.Length - 1]),
                        ProductType = productClassifier.ClassifyProducts(itemToAmount.Key),
                    };
                    _shoppingCart.CartItems.Add(new ShoppingCartItem
                    {
                        Product = product,
                        Quantity = itemToAmount.Value,
                        SaleTax = _salesTaxCalculator.CalculateSalesTax(product)
                    });
                }
                return _shoppingCart;
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter correct format. Ex: 1 Imported box of chocolates at 10.00 ");
            }
            return _shoppingCart;
        }

    }
}

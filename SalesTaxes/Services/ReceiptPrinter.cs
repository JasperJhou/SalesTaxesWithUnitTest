using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class ReceiptPrinter : IPrinter
    {
        /// <summary>
        /// Print a receipt based on the custom style
        /// </summary>
        /// <param name="shoppingCart"></param>
        public void PrintReceipt(ShoppingCart shoppingCart)
        {
            if (shoppingCart != null)
            {
                //We need to manupilate string here so we use StringBuilder which is mutable string type.
                StringBuilder receiptDetails = new StringBuilder();
                foreach (ShoppingCartItem carItem in shoppingCart.CartItems)
                {
                    if(carItem.Quantity > 1)
                    {
                        receiptDetails.Append(carItem.Product.Name).Append(": ").Append((carItem.SalePriceWithTax* carItem.Quantity).ToString("0.00")).Append(" (").Append(carItem.Quantity).Append(" @ ").Append(carItem.SalePriceWithTax.ToString("0.00")).Append(")").Append("\n");
                    }
                    else
                    {
                        receiptDetails.Append(carItem.Product.Name).Append(": ").Append(carItem.SalePriceWithTax.ToString("0.00")).Append("\n");
                    }
                    
                }
                receiptDetails.Append("Sales Taxes: ").Append(shoppingCart.TotalSalesTaxes).Append("\n").Append("Total: ").Append(shoppingCart.TotalSalesPrice.ToString("0.00"));
                Console.WriteLine("Here's your Receipt:");
                Console.WriteLine(receiptDetails);
            }
            else
            {
                throw new InvalidOperationException("Your shopping cart is empty");
            }
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SalesTaxes.UnitTests
{
    /// <summary>
    /// Naming Convention: MethodName_StateUnderTest_ExpectedBehavior
    /// </summary>
    [TestClass]
    public class ReceiptPrinterTests
    {
        [TestMethod]
        public void PrintReceipt_ShoppingCartIsEmpty_ThrowsAnException()
        {
            var receiptPrinter = new ReceiptPrinter();

            //create  empty shopping cart
            var shoppingCart = new ShoppingCart();
            shoppingCart.CartItems = new List<ShoppingCartItem>();

            receiptPrinter.PrintReceipt(shoppingCart);
        }

        [TestMethod]
        public void PrintReceipt_ShoppingCartIsNotEmpty_PrintReceipt()
        {
            var receiptPrinter = new ReceiptPrinter();

            //create shopping cart
            var shoppingCart = new ShoppingCart();
            shoppingCart.CartItems = new List<ShoppingCartItem>();
            var product = new Product
            {
                Name = "Imported bottle of perfume",
                SalePrice = 5.60m,
                ProductType = ProductType.Other,
            };
            shoppingCart.CartItems.Add(new ShoppingCartItem
            {
                Product = product,
                Quantity = 1,
                SaleTax = 6.00m
            });

            receiptPrinter.PrintReceipt(shoppingCart);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SalesTaxes.UnitTests
{
    /// <summary>
    /// Naming Convention: MethodName_StateUnderTest_ExpectedBehavior
    /// </summary>
    [TestClass]
    public class SalesTaxCalculatorTests
    {
        [TestMethod]
        public void CalculateSalesTax_IsBasicSales_CalculateBasicSalesTax()
        {
            var salesTaxCalculator = new SalesTaxCalculator();

            //Create basic product
            var basicProduct = new Product
            {
                Name = "bottle of perfume",
                SalePrice = 10.00m,
                ProductType = ProductType.Other,
            };

            var expected = new ShoppingCartItem();
            expected.SaleTax = 1.00m;

            Assert.AreEqual(expected.SaleTax, salesTaxCalculator.CalculateSalesTax(basicProduct));
        }

        [TestMethod]
        public void CalculateSalesTax_IsImportedSales_CalculateImportedSalesTax()
        {
            var salesTaxCalculator = new SalesTaxCalculator();

            //Create imported product
            var importedProduct = new Product
            {
                Name = "Imported box of chocolates",
                SalePrice = 10.00m,
                ProductType = ProductType.Food,
            };


            var expected = new ShoppingCartItem();
            expected.SaleTax = 0.50m;

            Assert.AreEqual(expected.SaleTax, salesTaxCalculator.CalculateSalesTax(importedProduct));
        }

        [TestMethod]
        public void CalculateSalesTax_IsBasicAndImportedSales_CalculateAndSumBothTax()
        {
            var salesTaxCalculator = new SalesTaxCalculator();

            //Create imported product
            var importedProduct = new Product
            {
                Name = "Imported bottle of perfume",
                SalePrice = 10.00m,
                ProductType = ProductType.Other,
            };

            
            var expected = new ShoppingCartItem();
            expected.SaleTax = 1.50m;

            Assert.AreEqual(expected.SaleTax, salesTaxCalculator.CalculateSalesTax(importedProduct));
        }

        [TestMethod]
        public void CalculateSalesTax_NeitherBasicAndImportedSales_NoTaxCalculated()
        {
            var salesTaxCalculator = new SalesTaxCalculator();

            //Create basic product
            var basicProduct = new Product
            {
                Name = "bottle of chocolates",
                SalePrice = 10.00m,
                ProductType = ProductType.Food,
            };


            var expected = new ShoppingCartItem();
            expected.SaleTax = 0.00m;

            Assert.AreEqual(expected.SaleTax, salesTaxCalculator.CalculateSalesTax(basicProduct));
        }
    }
}

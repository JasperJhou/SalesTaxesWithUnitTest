using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SalesTaxes.UnitTests
{
    /// <summary>
    /// Naming Convention: MethodName_StateUnderTest_ExpectedBehavior
    /// </summary>
    [TestClass]
    public class ProductClassifierTests
    {
        [TestMethod]
        public void ClassifyProducts_IsBook_ReturnBookProductType()
        {
            var productClassifier = new ProductClassifier();

            //Create product name
            var productName = "Book";

            productClassifier.ClassifyProducts(productName);

            Assert.AreEqual(ProductType.Books, productClassifier.ClassifyProducts(productName));
        }

        [TestMethod]
        public void ClassifyProducts_IsMedical_ReturnMedicalProductType()
        {
            var productClassifier = new ProductClassifier();

            //Create product name
            var productName = "pills";

            productClassifier.ClassifyProducts(productName);

            Assert.AreEqual(ProductType.Medical, productClassifier.ClassifyProducts(productName));
        }

        [TestMethod]
        public void ClassifyProducts_IsFood_ReturnFoodProductType()
        {
            var productClassifier = new ProductClassifier();

            //Create product name
            var productName = "chocolates";

            productClassifier.ClassifyProducts(productName);

            Assert.AreEqual(ProductType.Food, productClassifier.ClassifyProducts(productName));
        }

        [TestMethod]
        public void ClassifyProducts_IsOther_ReturnOtherProductType()
        {
            var productClassifier = new ProductClassifier();

            //Create product name
            var productName = "Perfume";

            productClassifier.ClassifyProducts(productName);

            Assert.AreEqual(ProductType.Other, productClassifier.ClassifyProducts(productName));
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SalesTaxes.UnitTests
{
    /// <summary>
    /// Naming Convention: MethodName_StateUnderTest_ExpectedBehavior
    /// </summary>
    [TestClass]
    public class ReceiptProcessorTests
    {
        [TestMethod]
        public void ProcessReceipt_InputIsNotCorrect_ThrowsAnException()
        {
            var receiptProcessor = new ReceiptProcessor(new SalesTaxCalculator());

            //Create incorrect input
            var itemList = new List<string>();
            itemList.Add("The Input should be followed as '1 Imported bottle of perfume at 47.50' ");

            receiptProcessor.ProcessReceipt(itemList);
        }
    }
}

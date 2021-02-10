
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTryAgain = true;

            while (isTryAgain)
            {
                Console.WriteLine("Enter your purchesed items or Enter 'q' to get receipt");
                var itemList = new List<string>();
                string inputLine = "";

                while (inputLine != "q")
                {
                    inputLine = Console.ReadLine().Trim(' ');
                    if (inputLine != "q" && !String.IsNullOrEmpty(inputLine))
                    {
                        itemList.Add(inputLine);
                    }
                }

                var receiptProcessor = new ReceiptProcessor(new SalesTaxCalculator());
                var shoppingCart = receiptProcessor.ProcessReceipt(itemList);
                var receiptPrinter = new ReceiptPrinter();

                Console.WriteLine("--------------------------------------------------");
                receiptPrinter.PrintReceipt(shoppingCart);
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Wanna try again? y/n");

                if (Console.ReadLine().ToUpper() == "Y")
                {
                    isTryAgain = true;
                    inputLine = "";
                }
                else
                {
                    isTryAgain = false;
                }
            }
        }
    }
}

using System;

namespace SalesTaxes
{
	public class Utility
    {
        /// <summary>
        /// Get product name from user's input
        /// </summary>
        /// <param name="inputLine"></param>
        /// <returns></returns>
        public static string GetProductName(string[] inputLine)
        {
            string name = String.Empty;
            for (int i = 1; i < inputLine.Length - 2; i++)
            {
                name = String.Concat(name, ' ', inputLine[i]).Trim(' ');
            }
            return name;
        }
    }
}

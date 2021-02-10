using System;

namespace SalesTaxes
{
	public class Utility
    {
        public static string GetName(string[] inputLine)
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

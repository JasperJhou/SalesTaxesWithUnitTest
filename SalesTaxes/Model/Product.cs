using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public class Product
    {
        public string Name { get; set; }
        public decimal SalePrice { get; set; }
        public bool IsImported { get { return new[] { "Imported", "imported" }.Any(Name.Contains); } }
        public ProductType ProductType { get; set; }
    }
}

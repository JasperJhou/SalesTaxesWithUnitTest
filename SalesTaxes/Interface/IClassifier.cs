﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxes
{
    public interface IClassifier
    {
        ProductType ClassifyProducts(string name);
    }
}

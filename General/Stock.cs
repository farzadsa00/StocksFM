using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksFM.General
{
    class Stock
    {
        public string Name { get; }
        public char StockType { get; set; }
        public char SubStockType { get; }
        public int CurrentPrice { get; set; }
        public int FinalPrice { get; set; }
        public string Status { get; set; }
    }
}

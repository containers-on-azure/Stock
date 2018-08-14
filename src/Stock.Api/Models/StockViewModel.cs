using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.Api.Models
{
    public class StockViewModel
    {
        public string Symbol { get; set; }
        public decimal Price { get; set; }
        public decimal TodaysHigh { get; set; }
        public decimal TodaysLow { get; set; }
        public string Name { get; set; }
    }
}

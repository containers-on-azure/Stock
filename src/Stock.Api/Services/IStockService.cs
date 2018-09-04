using Stock.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock.Api.Services
{
    public interface IStockService
    {
        Task<StockViewModel> GetStock(string symbol);
    }
}

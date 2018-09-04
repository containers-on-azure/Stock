using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stock.Api.Models;

namespace Stock.Api.Services
{
    public class InMemoryStockService : IStockService
    {
        Dictionary<string, StockViewModel> data = new Dictionary<string, StockViewModel>()
        {
            { "aapl", new StockViewModel { Symbol = "aapl", Name = "Apple Inc.", LastSale = 208.87m, ChangeValue = 1.34m, ChangePercentage = .65, ShareVolume = 25180005 } },
            { "qqq", new StockViewModel { Symbol = "qqq", Name = "Invesco QQQ Trust", LastSale = 180.32m, ChangeValue = -.20m, ChangePercentage = -.11, ShareVolume = 23852259} },
            { "mu", new StockViewModel { Symbol = "mu", Name = "Micron Technology", LastSale = 51.34m, ChangeValue = -.03m, ChangePercentage = -.06, ShareVolume = 23030109 } },
            { "msft", new StockViewModel { Symbol = "msft", Name = "Microsoft Corporation", LastSale = 108.21m, ChangeValue = -.79m, ChangePercentage = -.72, ShareVolume = 17892142 } },
            { "csco", new StockViewModel { Symbol = "csco", Name = "Cisco Systems", LastSale = 43.75m, ChangeValue = -.03m, ChangePercentage = -.07, ShareVolume = 17546299 } },
        };

        public Task<StockViewModel> GetStock(string symbol)
        {
            this.data.TryGetValue(symbol, out var stockViewModel);
            return Task.FromResult(stockViewModel); 
        }
    }
}

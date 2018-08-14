using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock.Api.Models;

namespace Stock.Api.Controllers
{
    /// <summary>
    /// Return stocks
    /// </summary>
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        // Taken from https://www.nasdaq.com on 2018-08-14
        static Dictionary<string, StockViewModel> stocks = new Dictionary<string, StockViewModel>()
        {
            { "aapl", new StockViewModel    { Price = 208.87m, Name = "Apple Inc", Symbol = "aapl", TodaysHigh = 210.952m, TodaysLow = 207.70m } },
            { "msft", new StockViewModel    { Price = 108.21m, Name ="Microsoft Corporation", Symbol = "msft", TodaysHigh = 109.58m, TodaysLow = 108.10m } },
            { "fb", new StockViewModel      { Price = 180.05m, Name = "Facebook, Inc", Symbol = "fb", TodaysHigh = 182.61m, TodaysLow = 178.90m } },
            { "tsla", new StockViewModel    { Price = 356.41m, Name = "Tesla, Inc", Symbol = "tsla", TodaysHigh = 363.19m, TodaysLow = 349.02m } },
            { "amzn", new StockViewModel    { Price = 1896.2m, Name = "Amazon.com, Inc", Symbol = "amzn", TodaysHigh = 1925m, TodaysLow = 1893.67m } },
            { "googl", new StockViewModel   { Price = 1248.64m, Name = "Alphabet Inc", Symbol = "googl", TodaysHigh = 1265.97m, TodaysLow = 1247.03m } },

        };


        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<StockViewModel>> List() => stocks.Values;
    


        [HttpGet]
        [Route("{symbol}")]
        public ActionResult<StockViewModel> Get(string symbol)
        {
            if (string.IsNullOrEmpty(symbol))
                return this.BadRequest("missing symbol");

            if (stocks.TryGetValue(symbol.ToLower(), out var stock))
                return stock;

            return NotFound();
        }

    }
}
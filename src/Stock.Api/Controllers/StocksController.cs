using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stock.Api.Models;
using Stock.Api.Services;

namespace Stock.Api.Controllers
{
    /// <summary>
    /// Information about single stocks
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IStockService stockService;

        public StocksController(IStockService stockService)
        {
            this.stockService = stockService;
        }

        /// <summary>
        /// Gets symbol information
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        [Route("{symbol}")]
        public async Task<ActionResult<StockViewModel>> GetStock(string symbol)
        {
            if (string.IsNullOrEmpty(symbol))
                return BadRequest("Missing symbol");

            var symbolViewModel = await this.stockService.GetStock(symbol);
            if (symbolViewModel == null)
                return NotFound();

            return symbolViewModel;
        }
    }
}

namespace Stock.Api.Models
{
    public class StockViewModel
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public decimal LastSale { get; set; }
        public decimal ChangeValue { get; set; }
        public double ChangePercentage { get; set; }
        public int ShareVolume { get; set; }
    }
}

    public class SecuritiesTrade
    {
        public int Quantity;
        public decimal Price;
    }

    public class StockTrade: SecuritiesTrade
    {
        public string? Symbol;
    }

    public class BondTrade: SecuritiesTrade
    {
        public string? Name;
        public int Duration;
    }


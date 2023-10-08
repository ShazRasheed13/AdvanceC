
public class CommisionCalculator
{
    public static decimal CalculateTradeCommission(SecuritiesTrade trade)=>
        trade switch
        {
            StockTrade { Quantity: var q } when q ==0 => throw new ArgumentException("Invalid"),
            StockTrade { Quantity: var q, Price: var p } when q>1000 && (q*p)>=10000.0m=> 5.0m,
            BondTrade { Quantity: var q, Price: var p, Duration: var d} when d==5 && (q*p)>=500.0m => 20m,
            _=> throw new ArgumentException("Unknown")

        };

    public static void PrintTradeCommission(SecuritiesTrade trade)
    {
        decimal commission = 0.0m;
        commission= CalculateTradeCommission(trade);

        if(trade is StockTrade st)
        {
            Console.WriteLine($"Stock Trade of {st.Quantity} of {st.Symbol} is {commission:C}");
        }
        else if (trade is BondTrade bt)
        {
            Console.WriteLine($"Bond Trade of {bt.Quantity} of {bt.Name} is {commission:C}");
        }
    }
}


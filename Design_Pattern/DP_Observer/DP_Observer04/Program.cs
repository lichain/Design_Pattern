namespace DP_Observer04
{
    /// <summary>
    /// 事件委託
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();

            StockObserver tom = new StockObserver("Tom", boss);
            NBAObserver john = new NBAObserver("John", boss);

            boss.Update += new EventHandler(tom.CloseStockMarket);
            boss.Update += new EventHandler(john.CloseNBADirectSeeding);
            
            boss.SubjectState = "I'm Boss, I'm come back!";

            boss.Notify();

            Console.Read();
        }
    }
}
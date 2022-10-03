namespace DP_Observer02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Secretary Jacye = new Secretary();

            StockObserver tom = new StockObserver("Tom", Jacye);
            NBAObserver john = new NBAObserver("John", Jacye);

            Jacye.Attach(tom);
            Jacye.Attach(john);

            Jacye.SecretaryAction = "Boss come back!";

            Jacye.Notify();

            Console.Read();
        }
    }
}
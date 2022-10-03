namespace DP_Observer01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Secretary Jacye = new Secretary();

            StockObserver tom = new StockObserver("Tom", Jacye);
            StockObserver john = new StockObserver("John", Jacye);

            Jacye.Attach(tom);
            Jacye.Attach(john);

            Jacye.SecretaryAction = "Boss come back!";

            Jacye.Notify();

            Console.Read();
        }
    }
}
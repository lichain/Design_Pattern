namespace DP_Observer03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();

            Secretary Jacye = new Secretary();

            StockObserver tom = new StockObserver("Tom", boss);
            NBAObserver john = new NBAObserver("John", boss);

            boss.Attach(tom);
            boss.Attach(john);

            boss.Detach(tom);

            boss.SubjectState = "I'm Boss, I'm come back!";

            boss.Notify();

            Console.Read();
        }
    }
}
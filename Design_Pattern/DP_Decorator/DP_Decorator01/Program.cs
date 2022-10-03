namespace DP_Decorator01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");

            Console.WriteLine("第一種裝扮:");

            xc.WearTShirts();
            xc.WearBigTrouser();
            xc.WearSneakers();
            xc.Show();

            Console.WriteLine("第二種裝扮:");
            xc.WearSuit();
            xc.WearTie();
            xc.WearLeatherShoes();
            xc.Show();

            Console.Read();
        }
    }
}
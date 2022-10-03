namespace DP_Decorator04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");

            Console.WriteLine("\n第一種裝扮:");

            TShirts dtx = new TShirts();
            BigTrouser kk = new BigTrouser();
            Sneakers pqx = new Sneakers();

            dtx.Decorate(xc);
            kk.Decorate(dtx);
            pqx.Decorate(kk);
            pqx.Show();

            Console.WriteLine("\n第二種裝扮:");
            Suit xz = new Suit();
            Tie ld = new Tie();
            LeatherShoes px = new LeatherShoes();

            xz.Decorate(xc);
            ld.Decorate(xz);
            px.Decorate(ld);
            px.Show();

            Console.Read();
        }
    }
}
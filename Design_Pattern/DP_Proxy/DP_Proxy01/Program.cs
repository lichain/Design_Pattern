namespace DP_Proxy01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl mary = new SchoolGirl();
            mary.Name = "Mary";

            Pursut tom = new Pursut(mary);

            tom.GiveDolls();
            tom.GiveFlowers();
            tom.GiveChocolate();

            Console.Read();
        }
    }
}
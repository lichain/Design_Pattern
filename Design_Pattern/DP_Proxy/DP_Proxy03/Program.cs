namespace DP_Proxy03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl mary = new SchoolGirl();
            mary.Name = "Mary";

            Proxy john = new Proxy(mary);

            john.GiveDolls();
            john.GiveFlowers();
            john.GiveChocolate();

            Console.Read();
        }
    }
}
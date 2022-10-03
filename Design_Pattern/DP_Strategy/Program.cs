namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero A = new Hero("A", new Colliding());
            Hero B = new Hero("B", new WaterBall());

            Battle battle = new Battle(A, B);
            battle.Start();
        }
    }
}
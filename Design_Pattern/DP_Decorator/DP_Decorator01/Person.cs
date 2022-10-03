using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Decorator01
{
    internal class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public void WearTShirts()
        {
            Console.WriteLine("大T");
        }

        public void WearBigTrouser()
        {
            Console.WriteLine("垮褲");
        }

        public void WearSneakers()
        {
            Console.WriteLine("破球鞋");
        }

        public void WearSuit()
        {
            Console.WriteLine("西裝");
        }

        public void WearTie()
        {
            Console.WriteLine("領帶");
        }

        public void WearLeatherShoes()
        {
            Console.WriteLine("皮鞋");
        }

        public void Show()
        {
            Console.WriteLine($"裝扮的{name}");
        }
    }
}

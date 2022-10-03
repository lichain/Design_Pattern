using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Decorator03
{
    abstract internal class Finery
    {
        public abstract void Show();
    }

    internal class TShirts : Finery
    {
        public override void Show()
        {
            Console.WriteLine("大T");
        }
    }

    internal class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.WriteLine("垮褲");
        }
    }

    internal class Sneakers : Finery
    {
        public override void Show()
        {
            Console.WriteLine("破球鞋");
        }
    }

    internal class Suit : Finery
    {
        public override void Show()
        {
            Console.WriteLine("西裝");
        }
    }

    internal class Tie : Finery
    {
        public override void Show()
        {
            Console.WriteLine("領帶");
        }
    }

    internal class LeatherShoes : Finery
    {
        public override void Show()
        {
            Console.WriteLine("皮鞋");
        }
    }
}

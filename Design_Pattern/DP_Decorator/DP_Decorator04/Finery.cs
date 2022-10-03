using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Decorator04
{
    internal class Finery : Person
    {
        protected Person component;

        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }

    internal class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("大T ");
            base.Show();
        }
    }

    internal class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("垮褲 ");
            base.Show();
        }
    }

    internal class Sneakers : Finery
    {
        public override void Show()
        {
            Console.Write("破球鞋 ");
            base.Show();
        }
    }

    internal class Suit : Finery
    {
        public override void Show()
        {
            Console.Write("西裝 ");
            base.Show();
        }
    }

    internal class Tie : Finery
    {
        public override void Show()
        {
            Console.Write("領帶 ");
            base.Show();
        }
    }

    internal class LeatherShoes : Finery
    {
        public override void Show()
        {
            Console.Write("皮鞋 ");
            base.Show();
        }
    }
}

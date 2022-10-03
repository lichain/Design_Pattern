using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Decorator04
{
    internal class ConcreteDecoratorA : Decorator
    {
        private string addedState = "";

        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("具體裝飾物件A的操作");
        }
    }
}

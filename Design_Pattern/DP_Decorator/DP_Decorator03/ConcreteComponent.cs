using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Decorator03
{
    internal class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具體物件的操作");
        }
    }
}

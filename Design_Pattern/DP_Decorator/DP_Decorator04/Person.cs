using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Decorator04
{
    internal class Person
    {
        public Person() { }

        private string name = "";
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"裝扮的{name}");
        }
    }
}

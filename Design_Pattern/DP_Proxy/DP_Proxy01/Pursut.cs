﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Proxy01
{
    internal class Pursut
    {
        SchoolGirl mm;
        public Pursut(SchoolGirl mm)
        {
            this.mm = mm;
        }

        public void GiveDolls()
        {
            Console.WriteLine($"{mm.Name} 送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine($"{mm.Name} 送你花");
        }

        public void GiveChocolate()
        {
            Console.WriteLine($"{mm.Name} 送你巧克力");
        }
    }
}

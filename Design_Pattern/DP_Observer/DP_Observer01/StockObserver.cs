using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Observer01
{
    internal class StockObserver
    {
        private string name;
        private Secretary sub;

        public StockObserver(string name, Secretary sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void Update()
        {
            Console.WriteLine($"{sub.SecretaryAction} {name} 關閉股票行情，繼續工作!");
        }
    }
}

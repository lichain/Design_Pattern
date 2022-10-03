using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Observer03
{
    internal class StockObserver : Observer
    {
        public StockObserver(string name, Subject sub) : base(name, sub) { }

        public override void Update()
        {
            Console.WriteLine($"{sub.SubjectState} {name} 關閉股票行情，繼續工作!");
        }
    }
}

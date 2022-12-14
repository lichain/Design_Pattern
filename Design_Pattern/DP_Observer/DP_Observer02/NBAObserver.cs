using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Observer02
{
    internal class NBAObserver : Observer
    {
        public NBAObserver(string name, Secretary sub) : base(name, sub) { }

        public override void Update()
        {
            Console.WriteLine($"{sub.SecretaryAction} {name} 關閉NBA直播，繼續工作!");
        }
    }
}

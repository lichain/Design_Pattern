using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Observer01
{
    internal class Secretary
    {
        private IList<StockObserver> observers = new List<StockObserver>();
        private string action = "";

        public void Attach(StockObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var o in observers)
            {
                o.Update();
            }
        }

        public string SecretaryAction
        {
            get { return action; }
            set { action = value; }
        }
    }
}

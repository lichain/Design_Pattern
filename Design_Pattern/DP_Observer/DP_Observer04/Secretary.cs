using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Observer04
{
    internal class Secretary
    {
        private IList<Observer> observers = new List<Observer>();
        private string action = "";

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
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

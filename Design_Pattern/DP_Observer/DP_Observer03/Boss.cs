using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Observer03
{
    internal class Boss : Subject
    {
        private IList<Observer> observers = new List<Observer>();
        private string action = "";

        public string SubjectState 
        {
            get { return action; } 
            set { action = value; } 
        }

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Observer04
{
    delegate void EventHandler();
    internal class Boss : Subject
    {
        public event EventHandler Update;

        private IList<Observer> observers = new List<Observer>();
        private string action = "";

        public string SubjectState 
        {
            get { return action; } 
            set { action = value; } 
        }


        public void Notify()
        {
            Update();
        }
    }
}

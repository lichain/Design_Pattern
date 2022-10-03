using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Observer04
{
    internal interface Subject
    {
        void Notify();
        string SubjectState
        {
            get;
            set;
        }
    }
}

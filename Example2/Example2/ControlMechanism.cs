using Example2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    abstract class ControlMechanism
    {
        protected ControlMechanism _control;

        public void Next(ControlMechanism control)
        {
            this._control = control; 
        }

        public abstract Result PaymentControl(int cash);
    }
}

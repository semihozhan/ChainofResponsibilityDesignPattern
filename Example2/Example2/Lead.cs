using Example2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Lead : ControlMechanism
    {
        public override Result PaymentControl(int cash)
        {
            if (cash < 2000)
            {
                return new Result { CurrentStep = "Lead Approved" };
            }
            else
            {
                return _control.PaymentControl(cash);
            }
        }
    }
}

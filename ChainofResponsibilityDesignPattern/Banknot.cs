using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityDesignPattern
{
    abstract class Banknot
    {
        protected Banknot _banknot;
        public void Next(Banknot banknot)
        {
            this._banknot = banknot;
        }


        public abstract Miktar ParaCek(int tutar);
    }
}

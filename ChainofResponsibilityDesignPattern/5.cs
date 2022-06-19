using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityDesignPattern
{
    internal class _5 : Banknot
    {
        public override Miktar ParaCek(int tutar)
        {
            if (tutar > 5)
            {
                return new Miktar
                {
                    Adet = tutar / 5,
                    Kalan = tutar % 5,
                    Tutar = 5
                };
            }
            else
            {
                return _banknot.ParaCek(tutar);
            }
        }
    }
}

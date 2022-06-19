using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityDesignPattern
{
    internal class _10 : Banknot
    {
        public override Miktar ParaCek(int tutar)
        {
            if (tutar > 10)
            {
                return new Miktar
                {
                    Adet = tutar / 10,
                    Kalan = tutar % 10,
                    Tutar = 10
                };
            }
            else
            {
                return _banknot.ParaCek(tutar);
            }
        }
    }
}

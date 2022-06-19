using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityDesignPattern
{
    internal class _1 : Banknot
    {
        public override Miktar ParaCek(int tutar)
        {
            if (tutar > 1)
            {
                return new Miktar
                {
                    Adet = tutar / 1,
                    Kalan = tutar % 1,
                    Tutar = 1
                };
            }
            else
            {
                return _banknot.ParaCek(tutar);
            }
        }
    }
}

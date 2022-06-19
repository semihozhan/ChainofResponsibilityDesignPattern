using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityDesignPattern
{
    internal class _20 : Banknot
    {
        public override Miktar ParaCek(int tutar)
        {
            if (tutar > 20)
            {
                return new Miktar
                {
                    Adet = tutar / 20,
                    Kalan = tutar % 20,
                    Tutar = 20
                };
            }
            else
            {
                return _banknot.ParaCek(tutar);
            }
        }
    }
}

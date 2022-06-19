using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityDesignPattern
{
    internal class _100 : Banknot
    {
        public override Miktar ParaCek(int tutar)
        {
            if (tutar > 100)
            {
                return new Miktar
                {
                    Adet = tutar / 100,
                    Kalan = tutar % 100,
                    Tutar = 100
                };
            }
            else
            {
                return _banknot.ParaCek(tutar);
            }
        }
    }
}

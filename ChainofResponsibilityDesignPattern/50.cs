using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityDesignPattern
{
    internal class _50 : Banknot
    {
        public override Miktar ParaCek(int tutar)
        {
            if (tutar > 50)
            {
                return new Miktar
                {
                    Adet = tutar / 50,
                    Kalan = tutar % 50,
                    Tutar = 50
                };
            }
            else
            {
                return _banknot.ParaCek(tutar);
            }
        }
    }
}

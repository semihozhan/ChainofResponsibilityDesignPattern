using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityDesignPattern
{
    internal class _200 : Banknot
    {
        public override Miktar ParaCek(int tutar)
        {
            if (tutar > 200)
            {
                return new Miktar
                {
                    Adet = tutar / 200,
                    Kalan = tutar % 200,
                    Tutar = 200
                };
            }
            else
            {
                return _banknot.ParaCek(tutar);
            }
        }
    }
}

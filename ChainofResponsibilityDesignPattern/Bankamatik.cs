using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibilityDesignPattern
{
    internal class Bankamatik
    {
        _200 _200 = new _200();
        _100 _100 = new _100();
        _50 _50 = new _50();
        _20 _20 = new _20();
        _10 _10 = new _10();
        _5 _5 = new _5();
        _1 _1 = new _1();

        public List<Miktar> ParaCek(int tutar)
        {
            Console.WriteLine("Toplam Tutar: " + tutar);

            _200.Next(_100);
            _100.Next(_50);
            _50.Next(_20);
            _20.Next(_10);
            _10.Next(_5);
            _5.Next(_1);

            Miktar sonuc = new Miktar();
            List<Miktar> sonuclar = new List<Miktar>();

            do
            {
                sonuclar.Add(sonuc = _200.ParaCek(tutar));
                tutar = sonuc.Kalan;
            } while (sonuc.Kalan > 0);

            foreach (var s in sonuclar)
            {
                Console.WriteLine("Tutar: " + s.Tutar + "\tAdet: " + s.Adet);
            }

            return null;
        }
    }
}

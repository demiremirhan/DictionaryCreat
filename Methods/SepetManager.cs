using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class SepetManager
    {
        public void Ekle(Urun urun
        )
        {
            Console.WriteLine("sepete eklendi." + urun.Adi );

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokadeti)
        {
            Console.WriteLine("sepete eklendi." + urunAdi);
        }


    }


}

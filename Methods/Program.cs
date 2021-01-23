using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Aciklama = "amasya elması";
            urun1.Fiyati = 15;
            

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Aciklama = "diyarbakır";
            urun2.Fiyati = 80;

            Urun[] urunler = new Urun[] {urun1, urun2};

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("-------------------");
            }


            Console.WriteLine("------------------Metodlar-------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("artmut","yeşil",12,15);

            
        }
    }
}

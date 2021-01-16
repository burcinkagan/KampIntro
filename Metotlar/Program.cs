using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //double fiyati = 15;
            //string aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 30;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler) //Urun kısmı var olarak da kalabilir.
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("*************************");
            }

            Console.WriteLine("***********metotlar***********");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            // ürüne ait örneğin stok bilgisi eklecek olsa aşağıdaki 
            //kodların hepsine tek tek stok bilgisi girmek gerekir.
            //sepetManager.Ekle2("armut", "yeşil armut", 12);
            //sepetManager.Ekle2("elma", "yeşil elma", 12);
            //sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12);
        }
    }
}

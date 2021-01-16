using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi:" + urun.Adi);
            
        }

        // ekle2'nin içine ürüne ait örneğin stok bilgisi eklecek olsa aşağıdaki 
        //kodlar patlar hepsine tek tek stok bilgisi girmek gerekir.
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi:" + urunAdi);
        }

    }
}

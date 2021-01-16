using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ??  (30)
            // int,decimal,float,double,dool = değer tip  ==> stack kısmında depolanır 
            //önce sayi1 ile sayi2'yi eşitler sonrasında sayi2yi istediği kadar değişsin tekrar eşitleme yapmadıkça aynı kalır.
            
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;

            //sayilar1[0] ?? (999)
            //array,class,interface = referans tip
            //sayilar1 oluşturulduğunda değeri stackte depolanır, new denildiğinde de adresi heapte kayıt edilir.
            //sayilar2 de sayilar1 gibi tanımlanır ve adresi heapte yer alır. sayilar1 = sayilar2 yapıldığında sayilar1'in referans numarası
            //sayilar2'nin referans numarasına eşit olur. yani sayilar1'in adresi sayilar2 olmuş oluyor.bu nedenle sayilar2[0]nin değeri 999 olursa
            //sayilar1'in de değeri güncelleniş oluyor.
        }
    }
}

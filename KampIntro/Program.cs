using System;

namespace KampIntro
{
    class Program
    {
        public class Product 
        {
            public string UrunAdi { get; set; }
            public string UrunMarka { get; set; }
            public string UrunFiyat { get; set; }
        }
        static void Main(string[] args)
        {
            Product Urun1 = new Product();
            Urun1.UrunAdi = "TEST";
            Urun1.UrunFiyat = "TEST";
            Urun1.UrunMarka = "TEST";

            Product Urun2 = new Product();
            Urun2.UrunAdi = "TEST2";
            Urun2.UrunFiyat = "TEST2";
            Urun2.UrunMarka = "TEST2";

            Product Urun3 = new Product();
            Urun3.UrunAdi = "TEST3";
            Urun3.UrunFiyat = "TEST3";
            Urun3.UrunMarka = "TEST3";

            Product[] Urunler = new Product[] { Urun1, Urun2, Urun3 };

            foreach (var urun in Urunler)
            {
                Console.WriteLine(urun.UrunAdi, urun.UrunFiyat, urun.UrunMarka);
            }
            Console.WriteLine("Foreach Dongu Sonu");
            Console.WriteLine("--------------------");
            for (int i = 0; i < Urunler.Length; i++)
            {
                Console.WriteLine(Urunler[i].UrunAdi+" "+Urunler[i].UrunFiyat +" "+Urunler[i].UrunMarka);
            }
            Console.WriteLine("For Dongu Sonu");
            Console.WriteLine("--------------------");
            int sayac = 0;
            while (sayac < Urunler.Length)
            {
                Console.WriteLine(Urunler[sayac].UrunMarka + " : " + Urunler[sayac].UrunFiyat + " : " + Urunler[sayac].UrunAdi);
                sayac++;
            }
            Console.WriteLine("While Dongu Sonu");
            Console.WriteLine("--------------------");
        }
    }
        
}

using System;

namespace KampIntro
{
    class Program
    {
        // Do not repeat yourself-- Kendini tekrarlama
        static void Main(string[] args)
        {

            string kategoriEtiketi = "Kategori";
            bool sistemeGirisYapmismi = true;
            Console.WriteLine(kategoriEtiketi);
            double dolarDun = 9.15;
            double dolarBugun = 8.15;
            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("Kullanıcı Sisteme Giriş Yapmış");
            }
            else
            {
                Console.WriteLine("Kullanıcı Sisiteme Giriş yapmamiş");
            }
            if (dolarBugun<dolarDun)
            {
                Console.WriteLine("Azalış");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("sabit");
            }
        }
    }
}

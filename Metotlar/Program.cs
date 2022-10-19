using System;

namespace Metotlar// Tekrar Tekrar kullanılabirligi sağlayan kod bloklarıdır.
    // C# Java Gibi dillerde herşey classlardan oluşur.
    // Classlar Özellik ve Operasyon tutar Özellik tutan operasyon tutmaz, operasyon tutan özellik tutmaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Adi = "Elma";
            product.Fiyati = 15;

            Product product1 = new Product();
            product1.Adi = "Karpuz";
            product1.Fiyati = 20;
            Product[] products = new Product[] { product,product1};
            foreach (var item in products)
            {
                Console.WriteLine(item.Adi);
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product);
            sepetManager.Add(product1);

        }
    }
}

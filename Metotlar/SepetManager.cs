using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager// Manager İle Başlıyorsa Bunlar Operasyon tutar
    {

        public void Add(Product product)
        {
            Console.WriteLine("Ürün Eklendi:"+product.Adi);
        }
    }
}

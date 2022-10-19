using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // int,decimal, float,double,bool=DegerTip -Stack
            //Array, class,interface=ReferanceTip-Heap
            // DegerTip'te sadece Deger degişir. Referans Tipte ise adres değişir

            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 30;
            Console.WriteLine(sayi1);

            int[] sayilar1 =new int[] { 10,20,30};
            int[] sayilar2 = new int[]{ 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);
        }
    }
}

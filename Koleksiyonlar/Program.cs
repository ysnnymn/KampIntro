using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Ali","Veli","Mehmet"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            isimler.Add("Yasin");
            Console.WriteLine("-----------");
            Console.WriteLine(isimler[3]);
            Console.WriteLine(isimler[0]);
        }
    }
}

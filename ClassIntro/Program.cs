using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C";
            kurs1.KursHocası = "Yaman";
            kurs1.BasarıOranı = 15;
            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Python";
            kurs2.KursHocası = "Yasin";
            kurs2.BasarıOranı = 50;
            Kurs[] kurslar = new Kurs[] { kurs1,kurs2};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı);
            }
        }
    }
    class Kurs
    {
        public string KursAdı { get; set; }
        public string KursHocası { get; set; }
        public int BasarıOranı { get; set; }

    }
}

using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            //ıhtiyacKrediManager.Hesapla();
            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
             BasvuruManager basvuruManager = new BasvuruManager();
            IKrediManager ıhtiyackrediManager = new IhtiyacKrediManager();
            IKrediManager konutkrediManager = new KonutKrediManager();
            IKrediManager tasitkrediManager = new TasitKrediManager();

            List<IKrediManager> krediManagers = new List<IKrediManager>() 
            {ıhtiyackrediManager,konutkrediManager};
           
            basvuruManager.BasvuruYap(tasitkrediManager,new DataBaseLoggerService());
            basvuruManager.KrediOnBilgilendirmesiYap(krediManagers);
           

            
            
        }
    }
}

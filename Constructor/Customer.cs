using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Customer
    {
        //default constructor
        public Customer() //Constructor: ctor+tab+tab
        {
            Console.WriteLine("Yapıcı Blok Çalıştı");
        }

        public Customer(int ıd,string firstName, string lastName)
        {
            // Bunları Atamazsan deger okuyamazsın
            Id = Id;
            FirstName = firstName;
            LastName = lastName;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}

using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {//instance(Örenek)
            Customer customer = new Customer { Id=1,FirstName="Yasin",LastName="Yaman"};
            Customer customer1 = new Customer(2,"Çınar","Yaman");
            Customer customer2 = new Customer();
            customer2.Id = 3;
            customer2.FirstName = "Fudayil";
            customer2.LastName = "Öztekin";
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);
        }
    }
}

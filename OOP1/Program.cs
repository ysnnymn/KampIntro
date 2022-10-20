using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.ProductName = "Masa";
            product1.UnitsInStock = 20;
            product1.UnitPrice = 500;

            Product product2 = new Product 
            { CategoryId = 2, Id = 2, ProductName = "Kalem", UnitsInStock = 40, UnitPrice = 80 };

            Product[] products = new Product[] {product1,product2 };
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            
        }

    }
}

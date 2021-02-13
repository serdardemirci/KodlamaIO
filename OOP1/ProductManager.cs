using System;
namespace OOP1
{
    public class ProductManager
    {
        public ProductManager()
        {
        }

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " added.");
        }
    }
}

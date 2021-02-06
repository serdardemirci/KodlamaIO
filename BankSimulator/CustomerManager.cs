using System;
namespace BankSimulator
{
    public class CustomerManager
    {
        public CustomerManager()
        {
        }

        public void Add(Customer customer)
        {
            Console.WriteLine("A new customer added!");
        }

        public void Show(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.Name + " removed");
        }
    }
}

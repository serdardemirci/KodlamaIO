using System;

namespace BankSimulator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                Name = "Serdar",
                Address = "Pattern Street 7"
            };

            Customer customer2 = new Customer
            {
                Id = 2,
                Name = "Ali",
                Address = "Design Street 7"
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Customer[] customers = new Customer[] { customer1, customer2 };
            customerManager.Show(customers);

            customerManager.Remove(customer2);
        }
    }
}

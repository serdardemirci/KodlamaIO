using System;
namespace BankSimulator
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string IBAN { get; set; }
        public string BIC { get; set; }

        public Customer()
        {
        }
    }
}

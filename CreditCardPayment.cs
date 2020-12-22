using System;
namespace Lab
{
    public class CreditCardPayment: Payment
    {
        private string name;
        private string number;

        public CreditCardPayment(string name, string number, double amount) : base(amount)
        {
            this.name = name;
            this.number = number;
        }

        public override void PaymentDetails()
        {
            Console.WriteLine($"A credit card payment from ${name} on card {number} for ${Amount}.");
        }

        public string Name { get { return name; } set { name = value; } }
        public string Number { get { return number; } set { number = value; } }
    }
}

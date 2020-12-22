using System;
namespace Lab
{
    public class Payment
    {
        private double amount;

        public Payment(double amount)
        {
            this.amount = amount;
        }

        public double Amount { get { return amount; } set { amount = value; } }

        public virtual void PaymentDetails()
        {
            Console.WriteLine($"A payment for ${amount}.");
        }
    }
}

using System;
namespace Lab
{
    public class CashPayment: Payment
    {
        public CashPayment(double amount) : base(amount)
        { }

        public override void PaymentDetails()
        {
            Console.WriteLine($"A cash payment for ${Amount}.");
        }
    }
}

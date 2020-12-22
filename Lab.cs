using System;
namespace Lab
{
    public class Lab
    {
        static void Main(string[] arguments)
        {
            CashPayment payment1 = new CashPayment(554.20);
            CashPayment payment2 = new CashPayment(3.56);

            CreditCardPayment payment3 = new CreditCardPayment("John Doe", "377231283078174", 4000);
            CreditCardPayment payment4 = new CreditCardPayment("Bill Nye", "343958755542060", 500.30);

            payment1.PaymentDetails();
            payment2.PaymentDetails();
            payment3.PaymentDetails();
            payment4.PaymentDetails();
        }
    }
}

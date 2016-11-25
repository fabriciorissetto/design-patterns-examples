using System;

namespace SimpleFactory
{
    public class Installment
    {
        public Installment(DateTime dueDate, double paymentValue)
        {
            DueDate = dueDate;
            PaymentValue = paymentValue;
        }

        public DateTime DueDate { get; private set; }
        public double PaymentValue { get; private set; }

    }
}
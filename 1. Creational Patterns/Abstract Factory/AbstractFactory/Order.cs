using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public class Order
    {
        public Order()
        {
            Installments = new List<Installment>();
        }

        public double Total { get; set; }
        public List<Installment> Installments { get; private set; }

        public void CreateInstallment(DateTime date, double value)
        {
            Installments.Add(new Installment(date, value));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public interface IPayment
    {
        void CreateInstallments(Order order);
    }

    public class Debit : IPayment
    {
        public void CreateInstallments(Order order)
        {
            order.Installments.Add(new Installment(DateTime.Today, order.Total));
        }
    }

    public class Credit : IPayment
    {
        ushort _installments;

        public Credit(ushort installments)
        {
            _installments = installments;
        }

        public void CreateInstallments(Order order)
        {
            var installments = _installments;
            var dueDate = DateTime.Today;
            var paymentValue = order.Total / _installments;
            while (installments > 0)
            {
                dueDate = dueDate.AddMonths(1);
                order.CreateInstallment(dueDate, paymentValue);
                installments--;
            }
        }
    }
}

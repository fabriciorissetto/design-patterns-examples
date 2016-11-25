using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Payment
    {
        public virtual void CreateInstallments(Order order)
        {
            order.CreateInstallment(DateTime.Today, order.Total);
        }

    }

    public class Debit : Payment
    {
        public override void CreateInstallments(Order order)
        {
            var dueDate = DateTime.Today;
            var paymentValue = order.Total * 0.90;
            order.CreateInstallment(dueDate, paymentValue);
        }
    }

    public class Credit2x : Payment
    {
        ushort _installments;

        public Credit2x()
        {
            _installments = 2;
        }

        public override void CreateInstallments(Order order)
        {
            var installments = _installments;
            var dueDate = DateTime.Today;
            var paymentValue = order.Total / _installments;
            while (installments > 0)
            {
                dueDate = dueDate.AddMonths(1);
                order.CreateInstallment(dueDate, paymentValue * 1.10);
                installments--;
            }
        }
    }

    public class Credit : Payment
    {
        public override void CreateInstallments(Order order)
        {
            order.CreateInstallment(DateTime.Today.AddMonths(1), order.Total * 1.05);
        }
    }
}

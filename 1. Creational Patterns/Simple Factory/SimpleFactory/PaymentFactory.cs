using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public static class PaymentFactory
    {
        public static IPayment PayWithCredit()
        {
            return new Credit(1);
        }

        public static IPayment PayWithCredit(ushort installments)
        {
            return new Credit(installments);
        }

        public static IPayment PayWithDebit()
        {
            return new Debit();
        }

    }
}

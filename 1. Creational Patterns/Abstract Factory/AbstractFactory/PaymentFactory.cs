using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public static class PaymentFactory
    {
        public static Payment PayWithCredit()
        {
            return new Credit();
        }

        public static Payment PayWithCredit2x()
        {
            return new Credit2x();
        }

        public static Payment PayWithDebit()
        {
            return new Debit();
        }

    }
}

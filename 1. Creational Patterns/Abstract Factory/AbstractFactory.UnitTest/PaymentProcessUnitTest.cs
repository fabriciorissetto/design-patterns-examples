// ==============================================================================================================
// Replaces this code using Polymorphism and an Object Factory.
// ==============================================================================================================
//      enum PaymentType
//      {
//          Credit1x,
//          Credit2x,
//          Debit
//      }
//      
//      public void Replace_Switch_For_Abstract_Factory()
//      {
//          var order = new Order();
//          order.Total = 100;
//          var paymentType = PaymentType.Credit2x;
//          IPayment payment;
//          switch (paymentType)
//          {
//              case PaymentType.Debit:
//                  payment = new Debit();
//                  break;
//              case PaymentType.Credit1x:
//                  payment = new Credit(1);
//                  break;
//              case PaymentType.Credit2x:
//                  payment = new Credit(2);
//                  break;
//              default:
//                  throw new NotImplementedException();
//          }
// 
//          payment.CreateInstallments(order);
//      }
// ==============================================================================================================

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbstractFactory.UnitTest
{
    [TestClass]
    public class PaymentProcessUnitTest
    {

        [TestMethod]
        public void Must_Create_Installment_For_One_Installment_Credit_Operation()
        {
            var order = new Order();
            order.Total = 100;

            var payment = PaymentFactory.PayWithCredit();
            payment.CreateInstallments(order);
            var expectedPayment = (order.Total) * 1.05;

            Assert.IsNotNull(order.Installments);
            Assert.IsTrue(order.Installments.Count == 1);
            Assert.IsTrue(order.Installments[0].PaymentValue == expectedPayment);
            Assert.IsTrue(order.Installments[0].DueDate == DateTime.Today.AddMonths(1));
        }

        [TestMethod]
        public void Must_Create_Installment_For_Two_Installment_Credit_Operation()
        {
            var order = new Order();
            order.Total = 100;

            var payment = PaymentFactory.PayWithCredit2x();
            payment.CreateInstallments(order);

            var expectedPayment = (order.Total / 2) * 1.10;
            Assert.IsNotNull(order.Installments);
            Assert.IsTrue(order.Installments.Count == 2);
            Assert.IsTrue(order.Installments[0].PaymentValue == expectedPayment);
            Assert.IsTrue(order.Installments[0].DueDate == DateTime.Today.AddMonths(1));
            Assert.IsTrue(order.Installments[1].PaymentValue == expectedPayment);
            Assert.IsTrue(order.Installments[1].DueDate == DateTime.Today.AddMonths(2));
        }

        [TestMethod]
        public void Must_Create_Installment_For_Debit_Operation()
        {
            var order = new Order();
            order.Total = 100;

            var payment = PaymentFactory.PayWithDebit();
            payment.CreateInstallments(order);

            var expectedPayment = order.Total * 0.90;
            Assert.IsNotNull(order.Installments);
            Assert.IsTrue(order.Installments.Count == 1);
            Assert.IsTrue(order.Installments[0].PaymentValue == expectedPayment);
            Assert.IsTrue(order.Installments[0].DueDate == DateTime.Today);
        }
    }
}

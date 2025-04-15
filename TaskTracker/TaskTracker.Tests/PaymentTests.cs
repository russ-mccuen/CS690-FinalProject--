using Xunit;
using TaskTracker.Models;
using System;

namespace TaskTracker.Tests
{
    public class PaymentTests
    {
        [Fact]
        public void Constructor_SetsPropertiesCorrectly()
        {
            int paymentId = 1;
            int invoiceId = 101;
            decimal amount = 150.00m;
            DateTime paymentDate = DateTime.Today;
            string method = "Credit Card";

            var payment = new Payment(paymentId, invoiceId, amount, paymentDate, method);

            Assert.Equal(paymentId, payment.PaymentId);
            Assert.Equal(invoiceId, payment.InvoiceId);
            Assert.Equal(amount, payment.Amount);
            Assert.Equal(paymentDate, payment.PaymentDate);
            Assert.Equal(method, payment.PaymentMethod);
        }

        [Fact]
        public void Payment_Properties_AreMutableIfApplicable()
        {
            var payment = new Payment(2, 202, 200.00m, DateTime.Today, "PayPal");

            payment.PaymentMethod = "Bank Transfer";

            Assert.Equal("Bank Transfer", payment.PaymentMethod);
        }

        [Fact]
        public void Payment_IsMadeToday()
        {
            var payment = new Payment(3, 303, 90.00m, DateTime.Today, "Cash");

            Assert.Equal(DateTime.Today, payment.PaymentDate);
        }

        [Fact]
        public void Payment_CanUseDifferentMethods()
        {
            var payment = new Payment(4, 404, 120.00m, DateTime.Today, "Zelle");

            Assert.Equal("Zelle", payment.PaymentMethod);
        }

        [Fact]
        public void Payment_Amount_CanBeNegative_IfNotValidated()
        {
            var payment = new Payment(5, 505, -20.00m, DateTime.Today, "Unknown");

            Assert.True(payment.Amount < 0);
        }
    }
}

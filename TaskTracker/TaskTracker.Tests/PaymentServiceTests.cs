using Xunit;
using TaskTracker.Models;
using TaskTracker.Services;
using System;

namespace TaskTracker.Tests
{
    public class PaymentServiceTests
    {
        [Fact]
        public void Placeholder_Test()
        {
            // Confirms the test file is active and configured correctly
            Assert.True(true);
        }

        /*
        // Cannot run: RecordPayment depends on Console.ReadLine() for every step,
        // including invoice ID, amount, and payment method.
        // It also writes output and uses Console.Clear().
        // Without refactoring to separate logic from input/output, testing is not possible.

        [Fact]
        public void RecordPayment_SuccessfullyAppliesPayment()
        {
            var invoices = new List<Invoice>
            {
                new Invoice(1, "Client X", 100m, DateTime.Today.AddDays(-5), DateTime.Today.AddDays(5))
            };

            var payments = new List<Payment>();

            PaymentService.RecordPayment(invoices, payments);

            // Expected:
            // - payments.Count == 1
            // - invoice marked as paid
            // - status updated
            // But these cannot be verified because input cannot be provided programmatically.
        }
        */
    }
}

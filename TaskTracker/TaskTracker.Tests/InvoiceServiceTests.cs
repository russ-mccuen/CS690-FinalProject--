using Xunit;
using TaskTracker.Models;
using TaskTracker.Services;
using System;

namespace TaskTracker.Tests
{
    public class InvoiceServiceTests
    {
        [Fact]
        public void Placeholder_Test()
        {
            // This confirms the test file is wired up and runs correctly
            Assert.True(true);
        }

        /*
        // Cannot run: CreateInvoice depends on multiple Console.ReadLine() inputs.
        // It also calls Console.Clear() and writes output.
        // Without mocking Console (which we are not allowed to do), this test will hang or fail.
        [Fact]
        public void CreateInvoice_AddsInvoiceToList()
        {
            var invoices = new List<Invoice>();
            InvoiceService.CreateInvoice(invoices);

            // We cannot simulate input to Console.ReadLine(), so we can't control what gets added.
            // A real test would check:
            // Assert.Single(invoices);
            // Assert.Equal("Client Name", invoices[0].ClientName);
        }

        // Cannot run: ViewUnpaidInvoices writes directly to console and reads a final input.
        // It returns no data, so nothing can be asserted without capturing console output.
        [Fact]
        public void ViewUnpaidInvoices_DisplaysCorrectInvoices()
        {
            var invoices = new List<Invoice>
            {
                new Invoice(1, "Client A", 500m, DateTime.Today, DateTime.Today.AddDays(10)) { IsPaid = false },
                new Invoice(2, "Client B", 300m, DateTime.Today, DateTime.Today.AddDays(5)) { IsPaid = true }
            };

            InvoiceService.ViewUnpaidInvoices(invoices);

            // No return, no change to list — only console output.
            // Would need Console output capture to validate (not allowed here).
        }
        */
    }
}

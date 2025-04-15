using Xunit;
using TaskTracker.Models;
using System;

namespace TaskTracker.Tests
{
    public class InvoiceTests
    {
        [Fact]
        public void Constructor_SetsPropertiesCorrectly()
        {
            int id = 1;
            string client = "Test Client";
            decimal amount = 250.00m;
            DateTime issueDate = DateTime.Today;
            DateTime dueDate = DateTime.Today.AddDays(30);

            var invoice = new Invoice(id, client, amount, issueDate, dueDate);

            Assert.Equal(id, invoice.Id);
            Assert.Equal(client, invoice.ClientName);
            Assert.Equal(amount, invoice.AmountDue);
            Assert.Equal(issueDate, invoice.IssueDate);
            Assert.Equal(dueDate, invoice.DueDate);
        }

        [Fact]
        public void Invoice_Defaults_AreCorrect()
        {
            var invoice = new Invoice(2, "Client B", 100.00m, DateTime.Today, DateTime.Today.AddDays(10));

            Assert.False(invoice.IsPaid);
            Assert.Equal("Pending", invoice.Status);
        }

        [Fact]
        public void Invoice_Status_CanBeUpdated()
        {
            var invoice = new Invoice(3, "Client C", 300.00m, DateTime.Today, DateTime.Today.AddDays(5));

            invoice.IsPaid = true;
            invoice.Status = "Paid";

            Assert.True(invoice.IsPaid);
            Assert.Equal("Paid", invoice.Status);
        }

        [Fact]
        public void Invoice_AmountDue_CanBeUpdated()
        {
            var invoice = new Invoice(4, "Client D", 200.00m, DateTime.Today, DateTime.Today.AddDays(15));

            invoice.AmountDue = 220.00m;

            Assert.Equal(220.00m, invoice.AmountDue);
        }

        [Fact]
        public void Invoice_DueDate_CanBeChanged()
        {
            var invoice = new Invoice(5, "Client E", 180.00m, DateTime.Today, DateTime.Today.AddDays(7));
            var newDueDate = DateTime.Today.AddDays(10);

            invoice.DueDate = newDueDate;

            Assert.Equal(newDueDate, invoice.DueDate);
        }
    }
}

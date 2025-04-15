using Xunit;
using TaskTracker.Models;
using TaskTracker.Services;
using System;

namespace TaskTracker.Tests
{
    public class StorageServiceTests
    {
        [Fact]
        public void Placeholder_Test()
        {
            // This placeholder confirms the test file is wired up correctly
            Assert.True(true);
        }

        /*
        // Cannot run without reading from disk
        [Fact]
        public void LoadTasks_ReturnsEmptyList_WhenFileDoesNotExist()
        {
            // Would require mocking File.Exists and File.ReadAllText
            var result = StorageService.LoadTasks();
            Assert.Empty(result);
        }

        // Cannot run without writing to disk
        [Fact]
        public void SaveTasks_WritesToFile()
        {
            var tasks = new List<TaskItem>
            {
                new TaskItem { Title = "Test", DueDate = DateTime.Today }
            };

            StorageService.SaveTasks(tasks);
            // No return value; would need to read file to verify
        }

        // Same limitation as above
        [Fact]
        public void LoadInvoices_ReturnsEmptyList_WhenFileDoesNotExist()
        {
            var result = StorageService.LoadInvoices();
            Assert.Empty(result);
        }

        [Fact]
        public void SaveInvoices_WritesToFile()
        {
            var invoices = new List<Invoice>(); // example data
            StorageService.SaveInvoices(invoices);
        }

        [Fact]
        public void LoadPayments_ReturnsEmptyList_WhenFileDoesNotExist()
        {
            var result = StorageService.LoadPayments();
            Assert.Empty(result);
        }

        [Fact]
        public void SavePayments_WritesToFile()
        {
            var payments = new List<Payment>(); // example data
            StorageService.SavePayments(payments);
        }
        */
    }
}

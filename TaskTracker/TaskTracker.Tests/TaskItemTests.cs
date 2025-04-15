using Xunit;
using TaskTracker.Models;
using System;

namespace TaskTracker.Tests
{
    public class TaskItemTests
    {
        [Fact]
        public void TaskItem_Defaults_IsCompletedFalse()
        {
            var task = new TaskItem
            {
                Title = "Test Task",
                DueDate = DateTime.Today
            };

            Assert.False(task.IsCompleted);
        }

        [Fact]
        public void TaskItem_OptionalProperties_CanBeNull()
        {
            var task = new TaskItem
            {
                Title = "Test Task",
                DueDate = DateTime.Today,
                Description = null,
                Priority = null,
                Client = null
            };

            Assert.Null(task.Description);
            Assert.Null(task.Priority);
            Assert.Null(task.Client);
        }

        [Fact]
        public void TaskItem_AllProperties_AssignCorrectly()
        {
            var dueDate = DateTime.Today.AddDays(3);
            var task = new TaskItem
            {
                Title = "Prepare Presentation",
                DueDate = dueDate,
                Description = "Finish slides and script",
                Priority = "High",
                Client = "Client X",
                IsCompleted = true
            };

            Assert.Equal("Prepare Presentation", task.Title);
            Assert.Equal(dueDate, task.DueDate);
            Assert.Equal("Finish slides and script", task.Description);
            Assert.Equal("High", task.Priority);
            Assert.Equal("Client X", task.Client);
            Assert.True(task.IsCompleted);
        }

        [Fact]
        public void TaskItem_IsOverdue_WhenDueDateIsInPast()
        {
            var task = new TaskItem
            {
                Title = "Past Task",
                DueDate = DateTime.Today.AddDays(-1)
            };

            Assert.True(task.DueDate < DateTime.Today);
        }

        [Fact]
        public void TaskItem_IsUpcoming_WhenDueDateIsInFuture()
        {
            var task = new TaskItem
            {
                Title = "Future Task",
                DueDate = DateTime.Today.AddDays(5)
            };

            Assert.True(task.DueDate > DateTime.Today);
        }
    }
}

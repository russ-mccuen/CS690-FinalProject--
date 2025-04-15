using Xunit;
using TaskTracker.Models;
using TaskTracker.Services;
using System;

namespace TaskTracker.Tests
{
    public class TaskServiceTests
    {
        [Fact]
        public void TaskItem_DefaultsToNotCompleted()
        {
            var task = new TaskItem
            {
                Title = "Test Task",
                DueDate = DateTime.Today
            };

            Assert.False(task.IsCompleted);
        }

        /*
        // Cannot run this test due to Console.ReadLine() in AddTask
        [Fact]
        public void AddTask_DoesNotAdd_WhenTitleIsEmpty()
        {
            var tasks = new List<TaskItem>();
            TaskService.AddTask(tasks); // Will hang due to Console.ReadLine()
            Assert.Empty(tasks);
        }

        // Cannot run this test due to Console.ReadLine() in CompleteTask
        [Fact]
        public void CompleteTask_MovesTaskToHistory()
        {
            var tasks = new List<TaskItem>
            {
                new TaskItem { Title = "Test", DueDate = DateTime.Today }
            };

            TaskService.CompleteTask(tasks); // Will hang due to Console.ReadLine()
            Assert.Empty(tasks); // Would be valid if input could be mocked
        }

        // Cannot observe output; method only writes to Console
        [Fact]
        public void ViewCompletedTasks_HandlesEmptyList()
        {
            TaskService.ViewCompletedTasks(); // No return value to assert
        }

        // No return value, so we can't verify sort order without refactor
        [Fact]
        public void ViewAllTasksSortedByDeadline_SortsCorrectly()
        {
            var tasks = new List<TaskItem>
            {
                new TaskItem { Title = "B", DueDate = DateTime.Today.AddDays(2) },
                new TaskItem { Title = "A", DueDate = DateTime.Today.AddDays(1) }
            };

            TaskService.ViewAllTasksSortedByDeadline(tasks); // No observable result
        }
        */
    }
}

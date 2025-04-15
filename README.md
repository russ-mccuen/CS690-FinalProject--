# CS690-FinalProject--
Rebuilt to actually work

**Original Repo Here: https://github.com/russ-mccuen/CS690-FinalProject**

# TaskTracker Project

## Overview
This project is a task manager application that includes functionalities for managing tasks, invoices, and payments. It also includes features for tracking completed tasks, viewing tasks due today, and handling invoices and payments.

## Version History
- **v2.0.1**: Latest release with completed task functionality, invoice and payment tracking, and the necessary infrastructure for testing. Rebuilt from 2.0.0 due to erro in initial build which prevented building with tests.

## How to Run the Project
1. **Download the ZIP**: To avoid issues with broken tests, download the ZIP file of the repository, which contains the fully functional code excluding the broken tests.
2. **Extract the ZIP**: Extract the ZIP file to a directory of your choice.
3. **Open the Project**: Open the project in Visual Studio Code or your preferred IDE.
4. **Build the Project**: Run `dotnet build` to build the project.
5. **Run the Project**: Execute `dotnet run` to start the application.

## Testing

Unit tests are included in the `TaskTracker.Tests` project but are **not part of the published release**.

To view and run tests locally:

1. Clone the full repository (not just the release zip)
2. Navigate to the solution directory
3. Run `dotnet test`

This project includes **19 fully runnable unit tests** for the core model classes (`TaskItem`, `Invoice`, `Payment`). These tests cover:

- Constructor behavior  
- Property validation  
- Logical conditions (e.g., overdue tasks, payment status)

For service classes that rely on `Console.ReadLine()` and `Console.WriteLine()`, test stubs are included but commented out with explanations. These methods are not testable without modifying the source code and are intentionally left untouched.


## Future Improvements
- Refactor the code to ensure that tests are fully functional.
- Implement additional features and improve the overall functionality of the application.

Thank you for using the TaskTracker project!


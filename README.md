# TaskTracker – CS690 Final Project

This is the rebuilt and functional version of the TaskTracker application.

> **Original Repository (for historical reference):**  
> [https://github.com/russ-mccuen/CS690-FinalProject](https://github.com/russ-mccuen/CS690-FinalProject)

---

## Overview

TaskTracker is a modular command-line application that allows users to:

- Add, complete, and view tasks
- Track completed and overdue items
- Create and manage invoices
- Record and apply payments
- View tasks sorted by due date

All data is saved in local `.json` files for persistence across sessions.

---

## Version History

- **v3.0.0** – Current release with:
  - Full feature set implemented
  - Clean separation of concerns
  - User Guide and Deployment Documentation added
  - Tests moved out of published build to allow successful publishing

- **v2.0.0**

---

## How to Run the Application

Follow the steps in the [Deployment Document](https://github.com/russ-mccuen/CS690-FinalProject--/wiki/Deployment-Document) to install the .NET runtime, download the release zip, and run the application from the terminal.  

No cloning or compilation required.

---

## Documentation

- [User Guide](https://github.com/russ-mccuen/CS690-FinalProject--/wiki/User-Guide) – Walkthrough of all features with screenshots
- [Deployment Document](https://github.com/russ-mccuen/CS690-FinalProject--/wiki/Deployment-Document)

---

## Testing

Unit tests are included in the `TaskTracker.Tests` project but are **not part of the published release**.

To run tests:

1. Clone this repository (not the release zip)
2. Navigate to the solution folder
3. Run:

   ```bash
   dotnet test
   ```

### Test Coverage Includes:

- Core model classes (`TaskItem`, `Invoice`, `Payment`)
- Constructor behavior, data validation, and business logic

Tests for `TaskService` and `InvoiceService` are stubbed but commented out, as they rely on `Console.ReadLine()` and would require refactoring to test properly.

---

## Future Improvements

Further improvements may be considered after the final submission depending on scope and feedback.

---

**Thank you for reviewing TaskTracker v2.0.0!**

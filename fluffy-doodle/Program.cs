using fluffy_doodle;

Console.WriteLine("Hello, World!");

Employee bethany = new Employee("Bethany", "Smith", "bethany@me.com", new DateTime(1979, 1, 16), 25);

// invoking methods on the new object
bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

double receivedWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");

// simplified syntax of instantiation of an object
Employee george = new("George", "Jones", "george@me.com", new DateTime(1984, 3, 28), 30);
george.DisplayEmployeeDetails();

// reference types vs value types
Employee testEmployee = bethany;
testEmployee.firstName = "Sabrina";
testEmployee.DisplayEmployeeDetails();
bethany.DisplayEmployeeDetails();
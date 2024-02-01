using fluffy_doodle;

Console.WriteLine("Hello, World!");

Employee bethany = new Employee("Bethany", "Smith", "bethany@me.com", new DateTime(1979, 1, 16), 25, EmployeeType.Research);

// invoking methods on the new object
bethany.DisplayEmployeeDetails();

//double receivedWageBethany = bethany.ReceiveWage(true);
//Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");

// simplified syntax of instantiation of an object
//Employee george = new("George", "Jones", "george@me.com", new DateTime(1984, 3, 28), 30);
//george.DisplayEmployeeDetails();

/* -------- reference types vs value types ---------- */
//Employee testEmployee = bethany;
//testEmployee.firstName = "Sabrina";
//testEmployee.DisplayEmployeeDetails();
//bethany.DisplayEmployeeDetails();


/* -------- Passing parameters by value---------- */

bethany.PerformWork(25);

int minimumBonus = 100;
int receivedBonus = bethany.CalculateBonus(minimumBonus);

// minimumBonus variable was passed in as a copy, therefore unchanged.
Console.WriteLine($"Minimum bonus: {minimumBonus}\nReceived bonus: {receivedBonus}");

/* -------- Passing parameters by reference ---------- */
//int bonusTax = 0;
//int receivedBonus2 = bethany.CalculateBonusAndBonusTax(minimumBonus, ref bonusTax);
//Console.WriteLine($"Minimum bonus: {minimumBonus}\nBonusTax: {bonusTax}\nReceived bonus: {receivedBonus2}");

/* -------- Using out ---------- */
int bonusTax;
int receivedBonus2 = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
Console.WriteLine($"Minimum bonus: {minimumBonus}\nBonusTax: {bonusTax}\nReceived bonus: {receivedBonus2}");

// working with structs
WorkTask task;
task.description = "Bake delicious pies";
task.hours = 3;
task.PerformWorkTask();

//fully qualified name
fluffy_doodle.Account.Customer customer = new fluffy_doodle.Account.Customer();
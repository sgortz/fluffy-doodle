﻿using fluffy_doodle;

Console.WriteLine("Hello, World!");

Employee bethany = new Employee("Bethany", "Smith", "bethany@me.com", new DateTime(1979, 1, 16), 25, EmployeeType.Research);

// invoking methods on the new object
bethany.DisplayEmployeeDetails();

//double receivedWageBethany = bethany.ReceiveWage(true);
//Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");

// simplified syntax of instantiation of an object
Employee george = new("George", "Jones", "george@me.com", new DateTime(1984, 3, 28), 30, EmployeeType.Research);
//george.DisplayEmployeeDetails();

/* -------- reference types vs value types ---------- */
//Employee testEmployee = bethany;
//testEmployee.firstName = "Sabrina";
//testEmployee.DisplayEmployeeDetails();
//bethany.DisplayEmployeeDetails();


#region Passing parameters by value

bethany.PerformWork(25);

int minimumBonus = 100;
int receivedBonus = bethany.CalculateBonus(minimumBonus);

// minimumBonus variable was passed in as a copy, therefore unchanged.
Console.WriteLine($"Minimum bonus: {minimumBonus}\nReceived bonus: {receivedBonus}");

#endregion

#region Passing parameters by reference 
//int bonusTax = 0;
//int receivedBonus2 = bethany.CalculateBonusAndBonusTax(minimumBonus, ref bonusTax);
//Console.WriteLine($"Minimum bonus: {minimumBonus}\nBonusTax: {bonusTax}\nReceived bonus: {receivedBonus2}");
#endregion

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

Employee mary = new("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Manager);
Employee bobJunior = new("Bob", "Spencer", "bob@snowball.be", new DateTime(1965, 1, 16), 30, EmployeeType.Research);
Employee kevin = new("Kevin", "Marks", "kevin@snowball.be", new DateTime(1965, 1, 16), 17, EmployeeType.StoreManager);
Employee kate = new("Kate", "Jones", "kate@snowball.be", new DateTime(1965, 1, 16), 10, EmployeeType.StoreManager);
Employee kim = new("Kim", "Jacobs", "kim@snowball.be", new DateTime(1993, 8, 8), 20, EmployeeType.StoreManager);

Employee[] employees = new Employee[7];
employees[0] = bethany;
employees[1] = george;
employees[2] = mary;
employees[3] = bobJunior;
employees[4] = kevin;
employees[5] = kate;
employees[6] = kim;

foreach(Employee e in employees)
{
    e.DisplayEmployeeDetails();
    var numberOfHoursWorked = new Random().Next(25);
    e.PerformWork(numberOfHoursWorked);
    e.ReceiveWage();
}
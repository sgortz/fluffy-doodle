namespace fluffy_doodle
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthday;

        // constant variable
        const int minimalHoursWorkedUnit = 1;

        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
        }

        // constructor overloading
        public Employee(string first, string last, string em, DateTime bd):this(first, last, em, bd, 0) { }

        public Employee(string first, string last, string em, DateTime bd, double rate)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthday = bd;
            hourlyRate = rate; 
        }

        //method overloading
        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }

        // using optional parameters
        public double ReceiveWage(bool resetHours = true)
        {
            wage = numberOfHoursWorked * hourlyRate;

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");

            if(resetHours ) { numberOfHoursWorked = 0; }

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nBirthday: \t{birthday.ToShortDateString()}\n");     
        }

    }
}

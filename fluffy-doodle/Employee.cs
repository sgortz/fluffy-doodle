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

        // constructor overloading
        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0) { }

        public Employee(string first, string last, string em, DateTime bd, double rate)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthday = bd;
            hourlyRate = rate;
        }

        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
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

        public int CalculateBonus(int bonus)
        {
            if(numberOfHoursWorked > 10)
            {
                bonus *= 2;
            }

            Console.WriteLine($"Employee got a bonus of {bonus}");
            return bonus;
        }

        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if(numberOfHoursWorked > 10) { bonus *= 2;}

            if(bonus >= 200) { 
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");

            return bonus;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nBirthday: \t{birthday.ToShortDateString()}\n");     
        }

    }
}

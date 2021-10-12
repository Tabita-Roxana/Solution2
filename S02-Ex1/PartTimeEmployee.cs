namespace Ex1
{
    public class PartTimeEmployee :Employee
    {
        public double HourlyWage;
        public int HoursPerMonth;

        public PartTimeEmployee(double hourlyWage, int hoursPerMonth)
        {
            HourlyWage = hourlyWage;
            HoursPerMonth = hoursPerMonth;
        }

        public override double GetMonthlySalary()
        {
            return HourlyWage * HoursPerMonth;
        }
    }
}
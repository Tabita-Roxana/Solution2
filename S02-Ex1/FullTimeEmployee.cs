namespace Ex1
{
    public class FullTimeEmployee :Employee
    {
        public double MonthlySalary;

        public FullTimeEmployee(double monthlySalary)
        {
            MonthlySalary = monthlySalary;
        }

        public override double GetMonthlySalary()
        {
            return MonthlySalary;
        }
    }
}
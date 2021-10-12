namespace Ex1
{
    public  abstract class Employee
    {
        public string Name { set; get; }

        public abstract double GetMonthlySalary();
    }
}
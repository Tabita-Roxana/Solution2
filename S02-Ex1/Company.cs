using System.Collections;
using System.Collections.Generic;

namespace Ex1
{
    public class Company
    {
        private List<Employee> employees;

        public Company()
        {
            employees = new List<Employee>();
        }

        public double GetMonthlyTotal()
        {
            double total = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                total+= employees[i].GetMonthlySalary();
            }

            return total;
        }

        public void HireNewEmployee(Employee emp)
        {
           employees.Add(emp);
        }
    }
}
using System;
using System.Runtime.Intrinsics.Arm;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee p1 = new PartTimeEmployee(140, 20);
            PartTimeEmployee p2 = new PartTimeEmployee(135, 15);
            FullTimeEmployee f1 = new FullTimeEmployee(35000.5);
            FullTimeEmployee f2 = new FullTimeEmployee(36600);

            Company c1 = new Company();
            c1.HireNewEmployee(p1);
            c1.HireNewEmployee(p2);
            c1.HireNewEmployee(f1);
            c1.HireNewEmployee(f2);
            Console.WriteLine(c1.GetMonthlyTotal());
        }
    }
}
using System;

namespace EmplWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel-Come to Employee Wage Computation Program");
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            
            if (empCheck==0)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}

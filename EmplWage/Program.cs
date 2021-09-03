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

            int Full_Time = 8;
            int Per_Hour_Sal = 20;
            int One_Day_Sal=0;
            
            if (empCheck==0)
            {
                Console.WriteLine("Employee is Full Time");
                One_Day_Sal = Per_Hour_Sal * Full_Time;
                Console.WriteLine("One Day Salary is: {0}", One_Day_Sal);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}

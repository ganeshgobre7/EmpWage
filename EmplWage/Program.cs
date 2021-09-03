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
            int Part_Time = 4;
            int Per_Hour_Sal = 20;
            int One_Day_Sal=0;
            int Total_Sal = 0;
            int No_Work_Day = 20;
            
            switch(empCheck)
            {
                case 1:

                    Console.WriteLine("Employee is Full Time");
                    One_Day_Sal = Per_Hour_Sal * Full_Time;
                    Console.WriteLine("One Day Salary of Full Time Employee: {0}", One_Day_Sal);
                    Total_Sal = One_Day_Sal * No_Work_Day;
                    Console.WriteLine("Total Salary Of Full Time Employee in a Month: {0}", Total_Sal);
                    break;

                case 2:

                    Console.WriteLine("Employee is Part Time");
                    One_Day_Sal = Per_Hour_Sal * Part_Time;
                    Console.WriteLine("One Day Salary of Part Time Employee: {0}", One_Day_Sal);
                    Total_Sal = One_Day_Sal * No_Work_Day;
                    Console.WriteLine("Total Salary Of Part Time Employee in a Month: {0}", Total_Sal);
                    break;

                default:
                    Console.WriteLine("Exit");
                    break;

            }  
               
                
            
        }
    }
}

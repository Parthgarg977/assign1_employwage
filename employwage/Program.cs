using System;


namespace employwage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Random random = new Random();
            int attendence = random.Next(0, 2);
            if (attendence == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            int Is_FullTime = 1;
            int RatePerHour = 20;
            int empHrs;
            int empcheck = random.Next(0, 2);
            if (empcheck == Is_FullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            int empWage = empHrs * RatePerHour;
            Console.WriteLine("Employee wage is {0}", empWage);
        }
    }
}
using System;


namespace employwage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_FullTime = 1;
            int RatePerHour = 20;
            int empHrs;
            Random random = new Random();
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
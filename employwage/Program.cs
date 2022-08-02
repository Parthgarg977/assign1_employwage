using System;


namespace employwage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            //UC1
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
            //UC2 UC3
           const int Is_FullTime = 1;
          const  int Is_PartTime = 2;
            int RatePerHour = 20;
            int empHrs;
            int empcheck = random.Next(0, 3);
            /* if (empcheck == Is_FullTime)
             {
                 empHrs = 8;
             }
             else if (empcheck == Is_PartTime)
             {
                 empHrs = 4;
             }
             else
             {
                 empHrs = 0;
             }*/
            switch (empcheck)
            {
                case Is_FullTime:
                    empHrs = 8;
                    break;
                    case Is_PartTime:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;

            }
            int empWage = empHrs * RatePerHour;
            Console.WriteLine("Employee wage is {0}", empWage);
            
        }
    }
}
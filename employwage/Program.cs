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
            //UC2 UC3 UC%
           const int Is_FullTime = 1;
          const  int Is_PartTime = 2;
            int TotalWorkingDaysPerMonth = 20;
            int TotalHrsPerMonth = 100;
            int totalhrs = 0;
            int totaldays = 0;
            int RatePerHour = 20;
            int empHrs;
            int TotalWagePerMonth=0;

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
            /* for (int i = 0; i < WorkingDaysPerMonth; i++)
             {
                 int empcheck = random.Next(0, 3);
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
                 TotalWagePerMonth += empWage;
                 Console.WriteLine("Employee wage is {0}", empWage);
             }*/
            while (totalhrs <= TotalHrsPerMonth && totaldays < TotalWorkingDaysPerMonth)
            {
                totaldays++;
                int empcheck = random.Next(0, 3);
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
                totalhrs+=empHrs;
                
              //  int empWage = empHrs * RatePerHour;
               // TotalWagePerMonth += empWage;
              //  Console.WriteLine("Employee wage is {0}", empWage);
            }
            int empWage = totalhrs * RatePerHour;
            Console.WriteLine("Total wage per month is {0}", empWage);
            
        }
    }
}
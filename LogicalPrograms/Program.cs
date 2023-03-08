using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an option to execute \n1.Fibonacci Series \n2.Perfect Number \n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter number");
                        int number = Convert.ToInt32(Console.ReadLine());
                        FibonacciSeries series = new FibonacciSeries();
                        series.PrintSeries(number);
                        break;
                    case 2:
                        Console.WriteLine("Enter number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.PerfectNum(num);
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
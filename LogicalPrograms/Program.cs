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
                Console.WriteLine("Choose an option to execute \n1.Fibonacci Series \n2.Perfect Number \n3.Prime Number \n4.Reverse a Number \n5.Day of Week"+ 
                    "\n6.Temperature Conversion \n7.Monthly Payment \n8.Exit");
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
                        Console.WriteLine("Enter number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.IsPrime(n);
                        break;
                    case 4:
                        Console.WriteLine("Enter number");
                        int a= Convert.ToInt32(Console.ReadLine());
                        ReverseNumber reverse = new ReverseNumber();
                        reverse.Reverse(a);
                        break;
                    case 5:
                        Console.WriteLine("Enter date");
                        int date = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter month");
                        int month = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter year");
                        int year = Convert.ToInt32(Console.ReadLine());
                        DayOfWeek dayOfWeek = new DayOfWeek();
                        dayOfWeek.Day(date,month,year);
                        break;
                    case 6:
                        Console.WriteLine("Enter Temperature");
                        int temp = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Choose option to perform \n1.Celcius to Fahrenheit   2.Fahrenheit to Celcius");
                        int opt = Convert.ToInt32(Console.ReadLine());
                        TemperatureConversion t = new TemperatureConversion();
                        t.TempConv(temp, opt);
                        break;
                    case 7:
                        Console.WriteLine("Enter Principal Loan Amount");
                        double P= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Interest Rate");
                        double R = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Year");
                        double Y = Convert.ToInt32(Console.ReadLine());
                        MonthlyPayment monthlyPayment = new MonthlyPayment();
                        monthlyPayment.Payment(P,Y,R);
                        break;
                    case 8:
                        flag = false;
                        break;
                }
            }
        }
    }
}
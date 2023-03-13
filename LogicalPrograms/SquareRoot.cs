using System;
namespace LogicalPrograms
{
    public class SquareRoot
    {
        public void Sqrt()
        {
            Console.WriteLine("Enter any number");
            double c = Convert.ToInt32(Console.ReadLine());
            double t= c;
            double epsilon = 1e-15;
            if (c > 0)
            {
                while (Math.Abs(t - c / t) > epsilon * t)
                {
                    t = ((c / t) + t) / 2;
                }
                Console.WriteLine(t);
            }
            else
                Console.WriteLine("Enter non-negative number only");
        }
    }
}

using System;
namespace LogicalPrograms
{
    public class MonthlyPayment
    {
        public void Payment(double P,double R, double Y)
        {
            double n = 12 * Y;
            double r = R / (12 * 100);            
            double payment = (P*r)/(1-Math.Pow((1+r),-n));
            Console.WriteLine("Monthly Payment: "+payment);
        }
    }
}

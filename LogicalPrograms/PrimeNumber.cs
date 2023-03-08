using System;
namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("{0} is not prime", num);
                    break;
                }                    
                else
                {
                    Console.WriteLine("{0} is prime", num);
                    break;
                }                    
            }
        }
    }
}

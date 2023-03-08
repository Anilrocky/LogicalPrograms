using System;
namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void IsPrime(int num)
        {
            int flag = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    flag = 0;
                    break;
                }                   
                    flag = 1;                    
            }
            if (flag == 0)
                Console.WriteLine(num + " is not Prime");
            else
                Console.WriteLine(num + " is Prime");
        }
    }
}

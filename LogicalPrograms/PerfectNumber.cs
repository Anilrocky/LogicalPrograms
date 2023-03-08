using System;
namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void PerfectNum(int num)
        {
            int result = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    result += i;
            }
            if (result == num)
                Console.WriteLine("{0} is a Perfect Number", num);
            else
                Console.WriteLine("{0} is not a Perfect Number", num);
        }
    }
}
using System;
namespace LogicalPrograms
{
    public class ReverseNumber
    {
        int rem = 0, res = 0;
        public void Reverse(int n)
        {
            while (n > 0)
            {
                rem = n % 10;
                res = res * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Reverse of Number is: "+res);
        }
    }
}

using System;
namespace LogicalPrograms
{
    public class DecimalToBinary
    {
        public void Binary()
        {
            Console.WriteLine("Enter a decimal value");
            int dec = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] arr = new int[dec];
            for (i = 0; dec > 0; i++)
            {
                arr[i] = dec % 2;
                dec = dec / 2;
            }
            Console.Write("Binary representation is: ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine(" ");
        }
    }
}

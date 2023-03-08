using System;
namespace LogicalPrograms
{
    public class TemperatureConversion
    {
        public void TempConv(int temp,int opt)
        {
            switch (opt)
            {
                case 1:
                    int F = (temp * 9 / 5) + 32;
                    Console.WriteLine(F + " F");
                    break;
                case 2:
                    int C = (temp - 32) * 5 / 9;
                    Console.WriteLine(C + " C");
                    break;
            }
        }
    }
}

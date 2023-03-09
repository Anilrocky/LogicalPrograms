using System;
namespace LogicalPrograms
{
    public class CouponNumbers
    {
        public void DistinctCoupon(int num)
        {
            int[] arr = new int[num];
            Random random = new Random();
            arr[0] = random.Next(0,num);
            for (int i = 1; i < num; i++)
            {
                int coupon = random.Next(0,num);
                for (int j = 1; j < i; j++)
                {
                    if (arr[j] != coupon)
                    arr[i] = coupon;
                }
                Console.WriteLine("Coupon Numbers: " + arr[i]);
            }
        }
    }
}

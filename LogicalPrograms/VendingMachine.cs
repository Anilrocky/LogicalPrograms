using System;
namespace LogicalPrograms
{
    public class VendingMachine
    {
        int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
        public void GetChange(int amount)
        {
            int count = 0;           
            for (int i = 0; i < notes.Length; i++)
            {
                if (amount / notes[i] >= 1 && amount != 0)
                {
                    int change = amount / notes[i];
                    count += change;
                    Console.WriteLine(notes[i] + " Notes---> " + change);
                    amount -= notes[i] * change;
                }               
            }
            Console.WriteLine("Total number of Notes: " + count);
        }
    }
}

using System;
namespace LogicalPrograms
{
    public class StopWatch
    {
        const string START = "Start", STOP = "Stop";
        public void Run()
        {
            TimeSpan timeSpan = TimeSpan.Zero;
            Console.WriteLine("Enter 'Start' to run stop watch");
            string start = Console.ReadLine();
            if (start == START)
            {
                int hour1 = timeSpan.Hours;
                int min1 = timeSpan.Minutes;
                int sec1 = timeSpan.Seconds;
                int milliSec1 = timeSpan.Milliseconds;
                Console.WriteLine("Enter 'Stop' to end stop watch");
                string stop = Console.ReadLine();
                if (stop == STOP)
                {
                    int hour2 = timeSpan.Hours;
                    int min2 = timeSpan.Minutes;
                    int sec2 = timeSpan.Seconds;
                    int milliSec2 = timeSpan.Milliseconds;
                    Console.WriteLine("Stop Watch Time: " + (hour2 - hour1) + ":" +(min2-min1)+":"+(sec2-sec1)+":"+(milliSec2-milliSec1));
                }               
            }
        }
    }
}

using System;
namespace LogicalPrograms
{
    public class StopWatch
    {
        const string START = "Start", STOP = "Stop";
        public void Run()
        {
            Console.WriteLine("Enter 'Start' to run stop watch");
            string start = Console.ReadLine();
            if (start == START)
            {
                DateTime timeSpan = DateTime.Now;
                int hour1 = timeSpan.Hour;
                int min1 = timeSpan.Minute;
                int sec1 = timeSpan.Second;
                int milliSec1 = timeSpan.Millisecond;
                Console.WriteLine("Enter 'Stop' to end stop watch");
                string stop = Console.ReadLine();
                if (stop == STOP)
                {
                    DateTime timeSpan1 = DateTime.Now;
                    int hour2 = timeSpan1.Hour;
                    int min2 = timeSpan1.Minute;
                    int sec2 = timeSpan1.Second;
                    int milliSec2 = timeSpan1.Millisecond;
                    Console.WriteLine("Stop Watch Time: " + (hour2 - hour1) + ":" +(min2-min1)+":"+(sec2-sec1)+":"+(milliSec2-milliSec1));
                }               
            }
        }
    }
}

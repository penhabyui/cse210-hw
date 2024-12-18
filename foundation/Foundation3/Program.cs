using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("03 Nov 2022", 30, 4.8); // 4.8 km in 30 minutes
        Cycling cycling = new Cycling("04 Nov 2022", 40, 20.0); // 20 kph for 40 minutes
        Swimming swimming = new Swimming("05 Nov 2022", 25, 20); // 20 laps in 25 minutes
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

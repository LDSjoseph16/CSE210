using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run = new Running("03 Nov 2022", 30, 3.0);
        activities.Add(run);

        Cycling cycle = new Cycling("03 Nov 2022", 45, 15.0);
        activities.Add(cycle);

        Swimming swim = new Swimming("03 Nov 2022", 20, 25);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(3.0, "03 Nov 2022", 30));      // 3 miles in 30 min
        activities.Add(new Cycling(15.0, "04 Nov 2022", 45));     // 15 mph for 45 min
        activities.Add(new Swimming(40, "05 Nov 2022", 25));      // 40 laps in 25 min

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
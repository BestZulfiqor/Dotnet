using System;

class Program
{
    static void Main(string[] args)
    {
        var lastWeekData = BirdCount.LastWeek();
        foreach (var item in lastWeekData)
        {
            Console.Write(item + " ");
        }
        int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        var birdCount = new BirdCount(birdsPerDay);
        Console.WriteLine("\nToday's count: " + birdCount.Today());

        Console.WriteLine("Increment today's count: " + birdCount.IncrementTodaysCount());
        Console.WriteLine("Has day without birds: " + birdCount.HasDayWithoutBirds());
        Console.WriteLine("Count for first 4 days: " + birdCount.CountForFirstDays(4));
        Console.WriteLine("Number of busy days: " + birdCount.BusyDays());
    }
}

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public int IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var item in birdsPerDay)
        {
            if (item == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int n)
    {
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            count += birdsPerDay[i];
        }
        return count;
    }

    public int BusyDays()
    {
        int count = 0;
        foreach (var item in birdsPerDay)
        {
            if (item >= 5)
            {
                count++;
            }
        }
        return count;
    }
}
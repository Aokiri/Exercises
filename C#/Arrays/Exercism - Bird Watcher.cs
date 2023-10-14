// Link to the exercise: https://exercism.org/tracks/csharp/exercises/bird-watcher

using System;

class BirdCount
{
    private int[] birdsPerDay;
    private static int[] _birdsLastWeek = { 0, 2, 5, 3, 7, 8, 4 };

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() =>
        _birdsLastWeek;

    public int Today() =>
        birdsPerDay[^1];

    public void IncrementTodaysCount() =>
        birdsPerDay[^1]++;

    public bool HasDayWithoutBirds()
    {
        foreach (int day in birdsPerDay)
        {
            if (day == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int counter = 0;

        for (int i = 0; i < numberOfDays; i++)
        {
            counter += birdsPerDay[i];
        }

        return counter;
    }

    public int BusyDays()
    {
        int busyCounter = 0;
        foreach (int day in birdsPerDay)
        {
            if (day >= 5)
                busyCounter++;
        }
        return busyCounter;
    }
}
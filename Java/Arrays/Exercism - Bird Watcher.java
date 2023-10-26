// Link to the exercise: https://exercism.org/tracks/java/exercises/bird-watcher

public class BirdWatcher {
    private final int[] birdsPerDay;
    private static int[] birdsLastWeek = { 0, 2, 5, 3, 7, 8, 4 };

    public BirdWatcher(int[] birdsPerDay) {
        this.birdsPerDay = birdsPerDay.clone();
    }

    public int[] getLastWeek() 
    {
        return birdsLastWeek;
    }

    public int getToday() 
    {
        return birdsPerDay[(birdsPerDay.length - 1)];
    }

    public void incrementTodaysCount() 
    {
        birdsPerDay[(birdsPerDay.length - 1)]++;
    }

    public boolean hasDayWithoutBirds() 
    {
        for (int day: birdsPerDay) 
        {
            if (day == 0)
                return true;
        }

        return false;
    }

    public int getCountForFirstDays(int numberOfDays) 
    {
        int counter = 0;

        for (int i = 0; i < numberOfDays; i++) 
        {
            if (i <= 6)
                counter += birdsPerDay[i];
        }

        return counter;
    }

    public int getBusyDays() 
    {
        int busyCounter = 0;

        for (int day: birdsPerDay)
        {
            if (day >= 5)
                busyCounter++;
        }

        return busyCounter;
    }
}

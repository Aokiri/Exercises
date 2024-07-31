// Link to the Exercise: https://exercism.org/tracks/csharp/exercises/lucians-luscious-lasagna

class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int mins)
    {
        return ExpectedMinutesInOven() - mins;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layersAdd, int minsInOven)
    {
        return PreparationTimeInMinutes(layersAdd) + minsInOven;
    }
// Link to the exercise: https://exercism.org/tracks/java/exercises/cars-assemble

public class CarsAssemble {

    // At its lowest speed (1), 221 cars are produced each hour.
    private final int LOWER_SPEED_PRODUCTION = 221;

    /* 
    The following table shows how speed influences the success rate:
        1 to 4: 100% success rate.
        5 to 8: 90% success rate.
        9: 80% success rate.
        10: 77% success rate.
    */
    public double successRate(int speed)
    {
        if (speed == 0)
            return 0.0;
        else if (speed >= 1 && speed <= 4)
            return 1.0;
        else if (speed >= 5 && speed <= 8)
            return 0.9;
        else if (speed == 9)
            return 0.8;
        else if (speed == 10)
            return 0.77;
        else
            return 0.0;
    }
    
    // Calculate the assembly line's production rate per hour, taking into account its current assembly line's speed 
    public double productionRatePerHour(int speed) 
    {
        return (speed * LOWER_SPEED_PRODUCTION) * this.successRate(speed);
    }

    // Calculate how many working cars are produced per minute.
    public int workingItemsPerMinute(int speed) 
    {
        return (int) this.productionRatePerHour(speed) / 60; // 60 = 60 seconds.
    }
}

public class Lasagna 
{
    // The time is displayed in minutes.
    private static final int COOKING_TIME = 40; // Cooking time is 40 mins.
    private static final int TIME_PER_LAYER = 2; // Each layer takes 2 mins to be ready.

    // Returns expected lenght of COOKING_TIME minutes (now 40).
    public int expectedMinutesInOven() 
    {
        return COOKING_TIME;
    }

    // Based on expected minutes, returns the remaining time in oven.
    public int remainingMinutesInOven(int actualMinutes) 
    {
        return this.expectedMinutesInOven() - actualMinutes;
    }

    // Returns the time you have spent cooking the lasagna.
    public int preparationTimeInMinutes(int layers) 
    {
        return layers * TIME_PER_LAYER;
    }
    
    // Returns the total time you have been spending in the lasagna.
    public int totalTimeInMinutes(int layers, int actualMinutes) 
    {
        return this.preparationTimeInMinutes(layers) + actualMinutes;
    }
 }

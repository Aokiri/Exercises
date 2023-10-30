// Link to the exercise: https://exercism.org/tracks/csharp/exercises/darts

using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double _distance = Math.Sqrt(x * x + y * y);

        if (_distance <= 1)
            return 10;
        else if (_distance <= 5)
            return 5;
        else if (_distance <= 10)
            return 1;
        else
            return 0;
    }
}
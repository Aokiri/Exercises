// Link to the exercise: https://exercism.org/tracks/csharp/exercises/roll-the-die

using System;

public class Player
{
    private Random dice = new();
    public int RollDie()
    {
        return dice.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        return dice.NextDouble() * 99.0 + 1.0;
    }
}

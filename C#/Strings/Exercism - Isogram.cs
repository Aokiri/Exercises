// Link to the exercise: https://exercism.org/tracks/csharp/exercises/isogram
using System.Collections.Generic;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        HashSet<char> chars = [];

        foreach (char c in word.ToLower())
        {
            if (!char.IsLetter(c)) continue;

            if (!chars.Add(c))
            {
                return false;
            }
        }
        return true;
    }
}
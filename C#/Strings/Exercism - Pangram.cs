// Link to this exercise: https://exercism.org/tracks/csharp/exercises/pangram

using System.Linq;
using System.Collections.Generic;

public static class Pangram
{
    private static readonly int ALPHABET_SIZE = 26;

    public static bool IsPangram(string input)
    {
        // First, format the sentence to delete spaces and lower the letters.
        string formatedInput = new string(input
            .ToLower()
            .Where(char.IsLetter)
            .ToArray());

        // Next, let's obtain an unique enumerable that have every letter.
        IEnumerable<char> uniqueWords = formatedInput.Distinct();

        // Then, check if it has the same amount of letters as the English Alphabet.
        return uniqueWords.Count() == ALPHABET_SIZE;
    }
}
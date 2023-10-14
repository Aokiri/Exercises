// Link to the exercise: https://exercism.org/tracks/csharp/exercises/bob

using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        string newChars = new(statement.Where(char.IsLetter).ToArray());
        
        if (newChars.All(char.IsUpper) && newChars.Length > 0  && statement.EndsWith("?"))
            return "Calm down, I know what I'm doing!";

        else if (statement.TrimEnd().EndsWith("?"))
            return "Sure.";

        else if (statement.All(char.IsWhiteSpace) || statement.Equals(""))
            return "Fine. Be that way!";

        else if (newChars.All(char.IsUpper) && newChars.Length > 0)
            return "Whoa, chill out!";

        else
            return "Whatever.";
    }
}
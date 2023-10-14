// Link to the exercise: https://exercism.org/tracks/csharp/exercises/squeaky-clean

using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder stringBuilder = new();
        bool WasHypen = false;

        foreach (char c in identifier)
        {
            bool IsNotLetter = !Char.IsLetter(c);
            bool IsNotSpace = !Char.IsWhiteSpace(c);
            bool IsNotControl = !Char.IsControl(c);
            bool IsGreek = Char.IsBetween(c, 'α', 'ω');

            if (c == '-')
            {
                WasHypen = true;
                continue;
            }

            if (WasHypen)
            {
                stringBuilder.Append(Char.ToUpper(c));
                WasHypen = false;
                continue;
            }

            if (IsNotLetter && IsNotSpace && IsNotControl)
                continue;

            if (IsGreek)
                continue;

            stringBuilder.Append(IsNotControl ? c : "CTRL");

        }

        stringBuilder.Replace(" ", "_");

        return stringBuilder.ToString();
    }
}

/* Another solution:

using System.Text;

public static class Identifier
{
    private static bool IsGreekLowercase(char c) => (c >= 'α' && c <= 'ω');

    public static string Clean(string identifier)
    {
        var stringBuilder = new StringBuilder();
        var isAfterDash = false;

        foreach (var c in identifier)
        {
            stringBuilder.Append(c switch
            {
                _ when IsGreekLowercase(c) => default,
                _ when isAfterDash => char.ToUpperInvariant(c),
                _ when char.IsWhiteSpace(c) => '_',
                _ when char.IsControl(c) => "CTRL",
                _ when char.IsLetter(c) => c,
                _ => default,
            });

            isAfterDash = c.Equals('-');
        }

        return stringBuilder.ToString();
    }
}
*/
// Link to the exercise: https://exercism.org/tracks/csharp/exercises/tim-from-marketing

using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        department ??= "OWNER";
        return id != null ? $"[{id}] - {name} - {department?.ToUpper()}" 
                          : $"{name} - {department?.ToUpper()}";

    }
}

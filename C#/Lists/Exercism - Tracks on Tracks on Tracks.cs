// Link to the exercise: https://exercism.org/tracks/csharp/exercises/tracks-on-tracks-on-tracks

using System;
using System.Collections.Generic;
using System.Linq;

public static class Languages
{
    public static List<string> NewList() =>
        new();

    public static List<string> GetExistingLanguages() =>
        new() { "C#", "Clojure", "Elm" };

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages) =>
        languages.Count;

    public static bool HasLanguage(List<string> languages, string language) =>
        languages.Contains(language);

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages) =>
        languages.Any() && languages.First() == "C#" 
        || (languages.IndexOf("C#") == 1 && languages.Count <= 3);

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages) =>
        !languages.GroupBy(lang => lang)
            .Any(group => group.Count() > 1);
}

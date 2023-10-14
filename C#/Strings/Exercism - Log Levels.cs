// Link to the exercise: https://exercism.org/tracks/csharp/exercises/log-levels

using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int indexOfColon = logLine.IndexOf(':');
        
        return indexOfColon != 0 ? logLine.Substring(indexOfColon + 1).Trim() : "String not found";
    }

    public static string LogLevel(string logLine)
    {
        int indexStart = logLine.IndexOf('[') + 1;
        int indexEnd = logLine.IndexOf(']') - 1;

        return indexStart != 0 && indexEnd != 0 ? logLine.Substring(indexStart, indexEnd).ToLower() : "String not found";
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}

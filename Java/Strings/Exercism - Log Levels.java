// Link to the exercise: https://exercism.org/tracks/java/exercises/log-levels

public class LogLevels {
    
    // Take the index of the colon in the string to return the message.
    public static String message(String logLine) 
    {
        int indexOfColon = logLine.indexOf(':');
        
        return indexOfColon != 0 
            ? logLine.substring(indexOfColon + 1).trim()
            : "String not found";
    }

    // Take the index of the brackets into the string to return the log level.
    public static String logLevel(String logLine) 
    {
        int indexStart = logLine.indexOf('[') + 1;
        int indexEnd = logLine.indexOf(']');

        return indexStart != 0 && indexEnd != 0
            ? logLine.substring(indexStart, indexEnd).toLowerCase()
            : "String not found";
    }

    // Reformats the entire log to one more readable.
    public static String reformat(String logLine) 
    {
        return String.format("%s (%s)", message(logLine), logLevel(logLine));
    }
}

/* Another way to resolve this exercise>>

import static java.lang.String.format;

public class LogLevels {

    public static String message(String logLine) {
        return logLine.split("]: ")[1]
                .trim();
    }

    public static String logLevel(String logLine) {
        return logLine.split("]: ")[0]
                .substring(1)
                .toLowerCase();
    }

    public static String reformat(String logLine) {
        return format("%s (%s)", message(logLine), logLevel(logLine));
    }
}
 */
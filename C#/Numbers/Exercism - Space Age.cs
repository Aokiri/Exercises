using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) => shirtNum switch
    {
        1 => "goalie",
        2 => "left back",
        3 | 4 => "center back",
        5 => "right back",
        6 | 7 | 8 => "midfielder",
        9 => "left wing",
        10 => "striker",
        11 => "right wing",
        _ => throw new NotSupportedException("The value provided was not expected.")
    };

    public static string AnalyzeOffField(object report) => report switch
    {
        int => "12",
        string => "asdasd",
        double => "asdad",

        _ => throw new NotSupportedException("The value provided was not expected.")
    };
}

// Link to the exercise: https://exercism.org/tracks/csharp/exercises/phone-number-analysis

using System;

public static class PhoneNumber
{
    private readonly string _newYorkNum = "212";
    private readonly string _fakeNum = "555";

    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] phoneSplitted = phoneNumber.Split('-');
        
        return (phoneSplitted[0] == _newYorkNum, phoneSplitted[1] == _fakeNum, phoneSplitted[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
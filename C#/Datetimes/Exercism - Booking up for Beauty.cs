// Link to the exercise: https://exercism.org/tracks/csharp/exercises/booking-up-for-beauty

using System;

static class Appointment
{
    private static readonly DateTime _today = DateTime.Now;
    private static readonly int _afternoonStartHour = 12;
    private static readonly int _afternoonEndHour = 18;
    private static readonly int[] _anniversaryMonthAndDay = { 9, 15 };

    public static DateTime Schedule(string appointmentDateDescription)
    {
        if (DateTime.TryParse(appointmentDateDescription, out DateTime scheduledDateTime))
            return scheduledDateTime;
        else
            return DateTime.MinValue;
    }

    public static bool HasPassed(DateTime appointmentDate) =>
        _today > appointmentDate;

    public static bool IsAfternoonAppointment(DateTime appointmentDate) =>
        appointmentDate.Hour >= _afternoonStartHour && appointmentDate.Hour < _afternoonEndHour;

    public static string Description(DateTime appointmentDate) =>
        $"You have an appointment on {appointmentDate}.";

    public static DateTime AnniversaryDate() =>
        new(DateTime.Now.Year, _anniversaryMonthAndDay[0], _anniversaryMonthAndDay[1]);
}
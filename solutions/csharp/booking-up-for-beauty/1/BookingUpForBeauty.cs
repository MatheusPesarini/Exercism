static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        if (appointmentDate < DateTime.Now)
        {
            return true;
        }

        return false;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        int hour = appointmentDate.Hour;

        if (hour >= 12 && hour < 18)
        {
            return true;
        }

        return false;
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate.ToString()}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15);
    }
}

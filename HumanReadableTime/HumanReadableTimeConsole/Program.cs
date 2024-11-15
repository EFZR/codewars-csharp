namespace HumanReadableTime;

public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        var hour = seconds / 3600;
        var mins = (seconds % 3600) / 60;
        var secs = seconds % 60;
        return $"{hour:D2}:{mins:D2}:{secs:D2}";
    }

    public static string GetReadableTime2(int seconds) => $"{seconds / 3600:00}:{seconds / 60 % 60:00}:{seconds % 60:00}";
}

class Program
{
    static void Main()
    {
        Console.WriteLine(TimeFormat.GetReadableTime(40000));
    }
}

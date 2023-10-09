namespace The_DJ;

public class Days
{
    public static int dayCounter = 0;
    public static void DisplayDay(int num)
    {
        int dayIndex = num % 7;
        if (dayIndex < 0)
        {
            dayIndex += 7;
        }
        Day day = (Day)dayIndex;

        Console.WriteLine("Day " + num + ": " + day);
        Days.dayCounter++;
    }
}


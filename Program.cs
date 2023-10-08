// the-dj-init
using The_DJ;
displayTitle();

// set name & create player
string playerName = string.Empty;
while (string.IsNullOrWhiteSpace(playerName))
{
    Console.WriteLine("Enter your DJ name (one word)");
    playerName = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(playerName))
    {
        Console.WriteLine("Invalid input");
    }
}
Console.Clear();
Player player = new(0, playerName, Reputation.BedroomDJ);

// DaysLoop
int week = 0;
while (Days.dayCounter < 31)
{
    if (Days.dayCounter % 7 == 0)
    {
        Console.WriteLine("Week " + week); ;
        player.DisplayStats(player);
        Console.ReadKey();
        week++;
    }
    Console.Clear();

    Days.DisplayDay(Days.dayCounter);

    player.DayMenu(player);

    Console.ReadKey();
}

void displayTitle()
{
    string[] title = File.ReadAllLines("../../../title.txt");
    foreach (var line in title)
    {
        Console.WriteLine(line);
    }
    Console.ReadKey();
    Console.Clear();
}


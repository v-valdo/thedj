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

player.DisplayStats(player);

Console.ReadLine();

player.DayMenu(player);

Console.ReadLine();

player.checkStats(player);

Console.ReadLine();

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


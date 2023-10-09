// the-dj-init
using The_DJ;
displayTitle();

// main menu
bool mainMenu = true;
while (mainMenu)
{
    string[] mainmenu = new string[4];
    mainmenu[0] = "1. New Game";
    mainmenu[1] = "2. Load Game";
    mainmenu[2] = "3. Credits";
    mainmenu[3] = "4. Exit";

    foreach (var item in mainmenu)
    {
        Console.WriteLine(item);
    }
    string? choice = Console.ReadLine();
    if (int.TryParse(choice, out int c) && c <= 4)
    {
        switch (c)
        {
            case 1:
                mainMenu = false;
                break;
            case 2: throw new NotImplementedException("Not implemented");
            case 3:
                Console.Clear();
                Console.WriteLine("Created by Valdemar Sersam, 2023");
                Console.ReadKey();
                Console.Clear();
                break;
            case 4:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }
    }
    else
    {
        Console.WriteLine("invalid input");
    }
}

Console.Clear();

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
        Console.Clear();
        Console.WriteLine("Week " + week); ;
        player.DisplayStats(player);
        Console.ReadKey();
        week++;
    }

    Console.Clear();

    Days.DisplayDay(Days.dayCounter);

    player.DayMenu(player);

    string? userinput = Console.ReadLine();
    if (int.TryParse(userinput, out int n))
    {
        switch (n)
        {
            case 1:
                DailyAction.begForMoney(Days.dayCounter, player);
                break;
            default:
                break;
        }

    }
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_DJ;

public class Player
{
    private Reputation Reputation { get; set; }
    public string Name { get; set; }
    private int Balance { get; set; }

    //Constructor
    public Player(int balance, string name, Reputation reputation)
    {
        Balance = balance;
        Name = "DJ " + name;
        Reputation = reputation;
    }

    public void checkStats(Player p)
    {
        Console.Clear();
        Console.WriteLine("Level 0: " + Reputation.Unwanted);
        Console.WriteLine("Level 1: " + Reputation.BedroomDJ);
        Console.WriteLine("Level 2: " + Reputation.PartyDJ);
        Console.WriteLine("Level 3: " + Reputation.ClubDJ);
        Console.WriteLine("Level 4: " + Reputation.FestivalDJ);
        Console.WriteLine("----------------");

        switch (p.Reputation)
        {
            case Reputation.Unwanted:
                Console.WriteLine("Your level is 0");
                break;
            case Reputation.BedroomDJ:
                Console.WriteLine("Your level is 1");
                break;
            case Reputation.PartyDJ:
                Console.WriteLine("Your level is 2");
                break;
            case Reputation.ClubDJ:
                Console.WriteLine("Your level is 3");
                break;
            case Reputation.FestivalDJ:
                Console.WriteLine("Your level is 4");
                break;
            default:
                Console.WriteLine("Invalid Reputation");
                break;
        }
    }
    public void DayMenu(Player p)
    {
        string[] menuChoices = new string[5];
        menuChoices[0] = "1. Beg for money outside clubs";
        menuChoices[1] = "2. Hone your skills in your bedroom";
        menuChoices[2] = "3. Book a gig at a party";
        menuChoices[3] = "4. Book a gig at a club";
        menuChoices[4] = "5. Book a gig at a festival";

        int reputationValue = (int)p.Reputation;

        for (int i = 0; i < menuChoices.Length; i++)
        {
            if (i == 0 || i <= reputationValue)
            {
                Console.WriteLine(menuChoices[i]);
            }
        }
    }
    public void DisplayStats(Player p)
    {
        Console.Clear();
        Console.WriteLine("Name " + p.Name);
        Console.WriteLine("Balance: $" + p.Balance);
        Console.WriteLine("Reputation: " + p.Reputation + "  //  Level " + (int)p.Reputation);
        Console.WriteLine();
    }
}
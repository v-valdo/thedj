namespace The_DJ
{
    public class DailyAction
    {
        public static void begForMoney(int day, Player p)
        {
            switch (day)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("You wake up late this gloomy monday.");
                    Console.WriteLine("The clubs have closed after the weekend and you fail to receive a single donation.");
                    Console.WriteLine("You buy yourself a dry hotdog for a dollar");

                    p.Balance -= 1;

                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();

                    Console.WriteLine("Tuesdays are sad, are they not?");
                    Console.WriteLine("You sit outside the dance halls of the city, begging for coins all day.");
                    Console.WriteLine("A random bypasser throws you a fiver in pity.");
                    Console.WriteLine("You buy yourself some lamb chops for 2 dollars");

                    p.Balance += 3;

                    Console.ReadKey();

                    break;
            }
        }
    }
}

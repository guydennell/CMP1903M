using System;

namespace CMP1903M
{
    public class GameMenu
    {
        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Game Menu!");
                Console.WriteLine("1. Play Sevens Out against computer");
                Console.WriteLine("2. Play Sevens Out against another player");
                Console.WriteLine("3. Play Three Or More against computer");
                Console.WriteLine("4. Play Three Or More against another player");
                Console.WriteLine("5. View Statistics");
                Console.WriteLine("6. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PlayGame(new SevensOut(), false);
                        break;
                    case "2":
                        PlayGame(new SevensOut(), true);
                        break;
                    case "3":
                        PlayGame(new ThreeOrMore(), false);
                        break;
                    case "4":
                        PlayGame(new ThreeOrMore(), true);
                        break;
                    case "5":
                        Statistics.Display();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void PlayGame(Game game, bool multiplayer)
        {
            if (!multiplayer)
            {
                game.PlayAgainstComputer();
            }
            else
            {
                game.PlayAgainstPlayer();
            }
        }
    }
}

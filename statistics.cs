using System;
using System.IO;

namespace CMP1903M
{
    public class Statistics
    {
        private const string highScoresFile = "highscores.txt";
        private const int maxHighScores = 10;

        public static void Update(string gameType, int rollCount, int total)
        {
            string entry = $"{DateTime.Now}: {gameType} - Rolls: {rollCount}, Total: {total}";

            Console.WriteLine($"Updating statistics: {entry}");

            using (StreamWriter writer = new StreamWriter(highScoresFile, true))
            {
                writer.WriteLine(entry);
            }

            // Trim excess high scores if more than 10
            TrimHighScores();
        }

        private static void TrimHighScores()
        {
            string[] highScores = File.ReadAllLines(highScoresFile);

            if (highScores.Length > maxHighScores)
            {
                // Keep only the last 10 lines
                string[] trimmedScores = new string[maxHighScores];
                Array.Copy(highScores, highScores.Length - maxHighScores, trimmedScores, 0, maxHighScores);

                // Write the trimmed scores back to the file
                File.WriteAllLines(highScoresFile, trimmedScores);
            }
        }

        public static void Display()
        {
            Console.WriteLine("Displaying statistics...");

            if (!File.Exists(highScoresFile))
            {
                Console.WriteLine("No statistics available yet.");
                return;
            }

            string[] highScores = File.ReadAllLines(highScoresFile);

            if (highScores.Length == 0)
            {
                Console.WriteLine("No statistics available yet.");
                return;
            }

            foreach (string score in highScores)
            {
                Console.WriteLine(score);
            }
        }
    }
}

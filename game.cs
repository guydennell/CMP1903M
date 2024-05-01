// Game.cs
using System;

namespace CMP1903M
{
    public abstract class Game
    {
        public abstract void PlayAgainstComputer();
        public abstract void PlayAgainstPlayer();
    }

    public class SevensOut : Game
    {
        private Die die;

        public SevensOut()
        {
            die = new Die();
        }

        public override void PlayAgainstComputer()
        {
            Console.WriteLine("Playing Sevens Out against computer...");
            int total = 0;
            int rollCount = 0;

            while (true)
            {
                int roll = die.Roll();
                rollCount++;
                Console.WriteLine($"Roll {rollCount}: {roll}");

                total += roll;
                if (total >= 7)
                {
                    Console.WriteLine($"Total is {total}. Game Over!");
                    break;
                }
            }

            Statistics.Update("SevensOut", rollCount, total);
        }

        public override void PlayAgainstPlayer()
        {
            Console.WriteLine("Playing Sevens Out against another player...");

            Console.WriteLine("Player 1's turn:");
            PlayAgainstComputer();

            Console.WriteLine("Player 2's turn:");
            PlayAgainstComputer();
        }
    }

    public class ThreeOrMore : Game
    {
        private Die die;

        public ThreeOrMore()
        {
            die = new Die();
        }

        public override void PlayAgainstComputer()
        {
            Console.WriteLine("Playing Three Or More against computer...");
            int total = 0;
            int rollCount = 0;

            while (true)
            {
                int roll = die.Roll();
                rollCount++;
                Console.WriteLine($"Roll {rollCount}: {roll}");

                total += roll;
                if (total >= 20)
                {
                    Console.WriteLine($"Total is {total}. Game Over!");
                    break;
                }
            }

            Statistics.Update("ThreeOrMore", rollCount, total);
        }

        public override void PlayAgainstPlayer()
        {
            Console.WriteLine("Playing Three Or More against another player...");

            Console.WriteLine("Player 1's turn:");
            PlayAgainstComputer();

            Console.WriteLine("Player 2's turn:");
            PlayAgainstComputer();
        }
    }
}

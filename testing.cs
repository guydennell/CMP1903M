using System;
using System.Diagnostics;

namespace CMP1903M
{
    class Testing
    {
        public static void RunTests()
        {
            Debug.Assert(TestSevensOut());
            Debug.Assert(TestThreeOrMore());
        }

        private static bool TestSevensOut()
        {
            Die die = new Die();
            int total = 0;
            int rollCount = 0;

            while (true)
            {
                int roll = die.Roll();
                rollCount++;
                total += roll;
                Debug.Assert(total <= 7, $"Total exceeded 7: {total}");
                if (total >= 7)
                {
                    break;
                }
            }

            return true;
        }

        private static bool TestThreeOrMore()
        {
            Die die = new Die();
            int total = 0;
            int rollCount = 0;

            while (true)
            {
                int roll = die.Roll();
                rollCount++;
                total += roll;
                Debug.Assert(total < 20, $"Total exceeded 20: {total}");
                if (total >= 20)
                {
                    break;
                }
            }

            return true;
        }
    }
}

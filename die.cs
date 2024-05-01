using System;

namespace CMP1903M
{
    public class Die
    {
        private static Random random = new Random();

        public int Roll()
        {
            return random.Next(1, 7);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesCore
{
    public static class RandomNumberGenerator
    {
        public static int GenerateNumber(int lowerRange, int upperRange)
        {
            Random random = new Random();
            int rng = random.Next(lowerRange, upperRange);
            return rng;
        }
    }
}

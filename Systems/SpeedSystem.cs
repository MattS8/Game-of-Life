using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Life
{
    public static class SpeedSystem
    {
        const float MaxMultiplier = 5;
        const float MinMultiplier = 0.25F;
        const float Interval = 0.25F;
        const int DefaultSpeed = 150;

        public static String GetMultiplierString(float multiplier)
        {
            return multiplier.ToString("0.00") + "x";
        }

        public static int GetSpeed(float multiplier)
        {
            return (int) (DefaultSpeed * (1 / multiplier));
        }

        public static float IncreaseSpeed(float currentMultiplier)
        {
            return currentMultiplier >= MaxMultiplier ? MaxMultiplier : currentMultiplier + Interval;
        }

        public static float DecreaseSpeed(float currentMultiplier)
        {
            return currentMultiplier <= MinMultiplier ? MinMultiplier : currentMultiplier - Interval;
        }
    }
}

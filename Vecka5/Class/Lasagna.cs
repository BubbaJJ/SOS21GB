using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka5.Class
{
    class Lasagna
    {
        private int _cookingTime = 40;
        private int _timePerLayer = 2;

        public int ExpectedMinutesInOven()
        {
            Console.WriteLine("Expected cooking time: {0}", _cookingTime);
            return _cookingTime;
        }

        public int RemainingMinutesInOven(int time)
        {
            int remainingTime = _cookingTime - time;
            Console.WriteLine("{0} minutes remaining.", remainingTime);
            return remainingTime;
        }

        public int PreperationTime(int layers)
        {
            int preparationTime = _timePerLayer * layers;
            Console.WriteLine("Total Preperation time: {0}", preparationTime);
            return preparationTime;
        }

        public int ElapsedTimeInMinutes(int layers, int time)
        {
            int preparationTime = _timePerLayer * layers;
            int elapsedTime = time + preparationTime;
            Console.WriteLine("Total elapsed time: {0}", elapsedTime);
            return elapsedTime;
        }
    }

    class MakeLasagna
    {
        public static void Solution()
        {
            Lasagna lasagna = new Lasagna();

            lasagna.ExpectedMinutesInOven();
            lasagna.RemainingMinutesInOven(20);
            lasagna.PreperationTime(4);
            lasagna.ElapsedTimeInMinutes(4, 30);
        }
    }
}
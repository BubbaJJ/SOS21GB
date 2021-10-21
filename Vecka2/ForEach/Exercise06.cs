using System;
namespace Vecka2.ForEach
{
    static class Exercise06
    {
        public static void Solution()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("SOS21GB");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("SOS");
                    }
                    else
                    {
                        Console.WriteLine("21GB");
                    }
                }
            }
        }
    }
}

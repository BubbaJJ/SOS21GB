using System;
namespace Vecka2.WhileDoWhile
{
    static class Exercise07
    {
        public static void Solution()
        {
            void While()
            {
                string[,] userInfo = new string[3, 4];

                int userCount = 0;
                int users = userInfo.GetLength(0);

                while (userCount < users)
                {
                    Console.WriteLine("Användare {0}", userCount + 1);
                    Console.Write("Namn: ");
                    userInfo[userCount, 0] = Console.ReadLine();
                    Console.Write("Ort: ");
                    userInfo[userCount, 1] = Console.ReadLine();
                    Console.Write("Skorstorlek: ");
                    userInfo[userCount, 2] = Console.ReadLine();
                    Console.Write("Favoritkaraktär: ");
                    userInfo[userCount, 3] = Console.ReadLine();
                    userCount++;
                }

                userCount = 0;
                while (userCount < users)
                {
                    Console.WriteLine("Användare {0}", userCount + 1);
                    Console.WriteLine("Namn: {0}", userInfo[userCount, 0]);
                    Console.WriteLine("Ort: {0}", userInfo[userCount, 1]);
                    Console.WriteLine("Skostorlek: {0}", userInfo[userCount, 2]);
                    Console.WriteLine("Favoritkaraktär: {0}", userInfo[userCount, 3]);
                    userCount++;
                }
            }

            void DoWhile()
            {
                string[,] userInfo = new string[3, 4];

                int userCount = 0;
                int users = userInfo.GetLength(0);

                do
                {
                    Console.WriteLine("Användare {0}", userCount + 1);
                    Console.Write("Namn: ");
                    userInfo[userCount, 0] = Console.ReadLine();
                    Console.Write("Ort: ");
                    userInfo[userCount, 1] = Console.ReadLine();
                    Console.Write("Skorstorlek: ");
                    userInfo[userCount, 2] = Console.ReadLine();
                    Console.Write("Favoritkaraktär: ");
                    userInfo[userCount, 3] = Console.ReadLine();
                    userCount++;
                } while (userCount < users);

                userCount = 0;
                do
                {
                    Console.WriteLine("Användare {0}", userCount + 1);
                    Console.WriteLine("Namn: {0}", userInfo[userCount, 0]);
                    Console.WriteLine("Ort: {0}", userInfo[userCount, 1]);
                    Console.WriteLine("Skostorlek: {0}", userInfo[userCount, 2]);
                    Console.WriteLine("Favoritkaraktär: {0}", userInfo[userCount, 3]);
                    userCount++;
                } while (userCount < users);
            }


            While();
            DoWhile();
        }
    }
}

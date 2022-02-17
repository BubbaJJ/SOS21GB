using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal class SingletonDemo
    {
        public static void GenericExample()
        {
            Console.WriteLine("--- GENERIC ---");
            Console.WriteLine("-- First call to constructor --");
            SingletonExample singleton1 = SingletonExample.GetInstance("Singleton 1");
            singleton1.PrintInfo();
            Console.WriteLine("-- Second call to constructor --");
            SingletonExample singleton2 = SingletonExample.GetInstance("Singleton 2");
            singleton2.PrintInfo();
            Console.WriteLine("\n-- Setting _instance to null --\n");
            singleton1.RemoveSingleton();
            Console.WriteLine("-- Third call to constructor --");
            SingletonExample singleton3 = SingletonExample.GetInstance("Singleton 3");
            singleton3.PrintInfo();
            Console.WriteLine();
        }

        public static void LoggerExample()
        {
            Console.WriteLine("--- LOGGER ---");
            Console.WriteLine("-- First call to constructor --");
            Logger logger1 = Logger.GetInstance;
            logger1.Log("Message");
            Console.WriteLine("-- Second call to constructor --");
            Logger logger2 = Logger.GetInstance;
            logger2.Log("Message");
            Console.WriteLine();
        }

    }
}

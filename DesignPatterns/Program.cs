using DesignPatterns.Adapter;
using DesignPatterns.Factory;
using DesignPatterns.Prototype;
using DesignPatterns.Singleton;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Singleton
            Console.WriteLine("\t--- SINGLETON ---\n");
            SingletonDemo.GenericExample();
            SingletonDemo.LoggerExample();

            // Factory
            Console.WriteLine("\t--- FACTORY ---\n");
            FactoryDemo.RunFactory();

            // Prototype
            Console.WriteLine("\t--- PROTOTYPE ---\n");
            PrototypeDemo.NonStaticMethod();
            PrototypeDemo.StaticMethod();

            // Adapter
            Console.WriteLine("\t--- ADAPTER ---\n");
            AdapterDemo.Adapter();
        }
    }
}
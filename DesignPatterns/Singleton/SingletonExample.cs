using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    class SingletonExample
    {
        // Counter för att hålla koll på antal skapade instanser.
        public static int Counter = 0;
        // _instance håller koll på den instans som skapats.
        private static SingletonExample _instance;
        private string _name;
        
        // Privat konstruktor (Nås endast inom klassen)
        private SingletonExample(string name)
        {
            this._name = name;
            Counter++;
        }

        // Metod som ansvarar för att anropa konstruktorn.
        public static SingletonExample GetInstance(string name)
        {
                // Kontrollera om det redan finns en instans av klassen.
                // Om nej, anropa konstruktorn.
                if(_instance == null)
                {
                    _instance = new SingletonExample(name);
                }
                // Returnera den nya, eller redan existerande, instansen.
                return _instance;
            
        }

        // Metod för att sätta _instance till null. (Demonstrationssyfte)
        public void RemoveSingleton()
        {
            _instance = null;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Counter: " + Counter);
        }
    }
}

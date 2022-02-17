using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal class Logger
    {
        private static Logger _instance;
        public static int counter;

        private Logger()
        {
            counter++;
        }

        public static Logger GetInstance
        {
            get 
            { 
                if(_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance; 
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(message + " Has been logged by instance " + counter);
        }
    }
}

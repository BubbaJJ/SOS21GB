using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    internal class DellLaptop : ILaptop
    {
        public void ShowModel()
        {
            Console.WriteLine("This is a Dell laptop.");
        }
    }
}

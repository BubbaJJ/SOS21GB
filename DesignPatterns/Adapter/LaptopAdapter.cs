using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    internal class LaptopAdapter : ILaptop
    {
        public void ShowModel() { }
        public static void ShowModel(ILaptop laptop)
        {
            laptop.ShowModel();
        }
    }
}

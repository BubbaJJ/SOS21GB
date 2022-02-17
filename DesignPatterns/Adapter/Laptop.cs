using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    class Laptop
    {
        public void CheckModel(ILaptop laptop)
        {
            LaptopAdapter.ShowModel(laptop);
        }
    }
}

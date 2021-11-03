using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka5.Class
{
    class Animal
    {
        public string Name;
        public bool CanFly;

        public Animal(string name, bool canFly)
        {
            this.Name = name;
            this.CanFly = canFly;
        }
    }

    class Bird : Animal
    {
        public string Color;

        public Bird(string name, bool canFly, string color) : base(name, canFly)
        {
            this.Color = color;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Can fly: {0}", CanFly);
            Console.WriteLine("Color: {0}", Color);
        }
    }
}
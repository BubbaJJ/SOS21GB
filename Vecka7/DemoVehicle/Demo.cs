using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka7.DemoVehicle
{
    static class Demo
    {
        public static void Examples()
        {
            new Vehicle(1, "Saab", 2000, 10);
            new Vehicle(2, "Volvo", 1923, 5);
            new Vehicle(3, "Ford", 2021, 1);
            new Vehicle(4, "Ford", 2001, 2);
            new Vehicle(5, "Volvo", 2005, 5);

            Vehicle.GetVehicleByBrand("Volvo");

            Vehicle.PrintInfo();
            Vehicle currentVehicle = Vehicle.GetVehicleById(1);

            currentVehicle.PrintVehicle();

            currentVehicle.AddTimeRented();
            currentVehicle.AddTimeRented();
            currentVehicle.AddTimeRented();

            Vehicle.AddTimeRentedStatic(currentVehicle);
            Vehicle.AddTimeRentedStatic(currentVehicle);
            Vehicle.AddTimeRentedStatic(currentVehicle);
        }
    }
}
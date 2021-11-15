using System;

namespace Vecka7
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.Write("ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Brand: ");
                string brand = Console.ReadLine();
                Console.Write("Year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Years to rent: ");
                int yearsToRent = Convert.ToInt32(Console.ReadLine());

                new Vehicle(id, brand, year, yearsToRent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            new Vehicle(1, "Saab", 2000, 10);
            new Vehicle(2, "Volvo", 1923, 5);
            new Vehicle(3, "Ford", 2021, 1);

            //Vehicle.PrintInfo();
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
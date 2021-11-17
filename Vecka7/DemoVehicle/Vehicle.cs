using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka7
{
    class Vehicle
    {
        private static List<Vehicle> vehicles = new List<Vehicle>();

        private int _id;
        private string _brand;
        private int _year;
        private int _timesRented = 0;
        private DateTime _timeRegistered;
        private DateTime _stopRenting;

        public Vehicle(int _id, string _brand, int _year, int yearsToRent)
        {
            this._id = _id;
            this._brand = _brand;
            this._year = _year;
            this._timeRegistered = DateTime.Now;
            this._stopRenting = _timeRegistered.AddYears(yearsToRent);
            vehicles.Add(this);
        }

        public Vehicle(int id, string brand, int year)
        {
            this._id = id;
            this._brand = brand;
            this._year = year;
        }

        public static void GetVehicleByBrand(string brand)
        {
            var car = from x in vehicles where x._brand == brand orderby x._year select x;
            var cars = vehicles.Where(x => x._brand == brand).OrderByDescending(x => x._year);
            var cars2 = from xxx in vehicles select xxx;
            var cars3 = from name in vehicles where name._brand.Length > 4 select name;

            foreach (var item in cars3)
            {
                Console.WriteLine(item._brand + " " + item._year);
            }
        }

        public void PrintVehicle()
        {
            Console.WriteLine();
            Console.WriteLine(_brand);
            Console.WriteLine(_year);
        }

        public void AddTimeRented()
        {
            _timesRented++;
            Console.WriteLine("ID: {0}", _id);
            Console.WriteLine(_timesRented);
        }

        public static void AddTimeRentedStatic(Vehicle veh)
        {
            veh._timesRented++;
            Console.WriteLine("ID: {0}", veh._id);
            Console.WriteLine(veh._timesRented);
        }

        public static void PrintInfo()
        {
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine();
                Console.WriteLine("ID: {0}", v._id);
                Console.WriteLine("Brand: {0}", v._brand);
                Console.WriteLine("Year: {0}", v._year);
                Console.WriteLine("Times rented: {0}", v._timesRented);
                Console.WriteLine("Time registered: {0}", v._timeRegistered);
                Console.WriteLine("Date to stop renting: {0}", v._stopRenting);
            }
        }

        public static Vehicle GetVehicleById(int id)
        {
            foreach (Vehicle v in vehicles)
            {
                if (v._id == id)
                {
                    return v;
                }
            }
            return null;
        }
    }
}
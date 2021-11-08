using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka5.Exercises
{
    class Car
    {
        #region Private Fields

        private string _brand;
        private string _color;
        private int _doors;
        private string _fuel;
        private int _fuelCapacity;
        private string _licensePlate;
        private double _litresPerMile;
        private double _currentFuelAmount;
        private double _odometer = 0;
        private int _year;

        #endregion Private Fields

        #region Public Constructors

        public Car()
        {
        }

        public Car(string licensePlate, string brand, string color, int year)
        {
            this._licensePlate = licensePlate;
            this._brand = brand;
            this._color = color;
            this._year = year;
        }

        public Car(string licensePlate, string brand, string color, int year, string fuel, double litresPerMile, int doors, int fuelCapacity)
        {
            this._licensePlate = licensePlate;
            this._brand = brand;
            this._color = color;
            this._year = year;
            this._fuel = fuel;
            this._litresPerMile = litresPerMile;
            this._doors = doors;
            this._fuelCapacity = fuelCapacity;
            this._currentFuelAmount = _fuelCapacity;
        }

        #endregion Public Constructors

        #region Public Properties

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public double CurrentFuelAmount
        {
            get
            {
                return _currentFuelAmount;
            }
        }

        public int Doors
        {
            get
            {
                return _doors;
            }
            set
            {
                _doors = value;
            }
        }

        public string Fuel
        {
            get
            {
                return _fuel;
            }
            set
            {
                _fuel = value;
            }
        }

        public int FuelCapacity
        {
            get
            {
                return _fuelCapacity;
            }
            set
            {
                _fuelCapacity = value;
            }
        }

        public string LicensePlate
        {
            get
            {
                return _licensePlate;
            }
            set
            {
                _licensePlate = value;
            }
        }

        public double LitresPerMile
        {
            get
            {
                return _litresPerMile;
            }
            set
            {
                _litresPerMile = value;
            }
        }

        public double Odometer
        {
            get
            {
                return _odometer;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        #endregion Public Properties

        #region Public Methods

        public void CheckFuelAmount()
        {
            if (_currentFuelAmount == _fuelCapacity)
            {
                Console.WriteLine("Tank is full.");
            }
            else
            {
                Console.WriteLine("{0}L left in the tank.", _currentFuelAmount);
            }
        }

        public void Drive(double miles)
        {
            double fuelNeeded = miles * _litresPerMile;
            if (fuelNeeded <= _currentFuelAmount)
            {
                Console.WriteLine("On the road again!");
                Console.WriteLine("{0} miles added to the odometer.", miles);
                _odometer += miles;
                _currentFuelAmount -= fuelNeeded;
            }
            else
            {
                Console.WriteLine("Not enough fuel.");
            }
        }

        public void FuelUp(int litres)
        {
            if ((_currentFuelAmount + litres) <= _fuelCapacity)
            {
                Console.WriteLine("Fueling up the car.");
                Console.WriteLine("{0}L added to the tank.", litres);
                _currentFuelAmount += litres;
            }
            else if (_currentFuelAmount == _fuelCapacity)
            {
                Console.WriteLine("Tank is already full.");
            }
            else
            {
                double fuelNeeded = _fuelCapacity - _currentFuelAmount;
                Console.WriteLine("Not all the gas was needed.");
                Console.WriteLine("{0}L added to the tank.", fuelNeeded);
                _currentFuelAmount = _fuelCapacity;
            }
        }

        public void StartCar()
        {
            Console.WriteLine("Turning key...");
            Console.WriteLine("Car is running.");
        }

        public void StopCar()
        {
            Console.WriteLine("Turning key...");
            Console.WriteLine("Car is no longer running.");
        }

        #endregion Public Methods
    }

    class Exercise06
    {
        #region Public Methods

        public static void Solution()
        {
            Car car1 = new Car();

            Car car2 = new Car("ABC123", "Volvo", "Black", 2004);

            Car car3 = new Car("ABC123", "Volvo", "Black", 2004, "Diesel", 0.8, 4, 57);

            car3.StartCar();
            car3.CheckFuelAmount();
            car3.Drive(200);
            car3.CheckFuelAmount();
            car3.FuelUp(12);
            car3.FuelUp(12);
            car3.FuelUp(12);
            car3.StopCar();
        }

        #endregion Public Methods
    }
}
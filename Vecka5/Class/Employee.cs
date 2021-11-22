using System;

namespace Vecka5.Class
{
    public abstract class Employee
    {
        protected int _age;
        protected string _name;
    }

    public class User : Employee
    {
        public void Print()
        {
            Console.WriteLine(_age);
        }
    }
}
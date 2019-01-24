using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Person // : object, sealed/abstract - нельзя наследоваться / можно наследоваться
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        public Person(string fullName)
        {
            FullName = fullName;
        }
        public string GetFullInfo()
        {
            return $"{Id},{FullName},{Age}";
        }
        public virtual void MakeWork() // желательно 
        {
            // какая-то базовая реализация
        }
        public abstract void ToDo(); // обязаны реализовать метод в дочерних классах
    }
}

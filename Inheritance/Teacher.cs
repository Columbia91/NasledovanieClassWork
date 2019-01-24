using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Teacher : Person
    {
        public string SubjectName { get; set; }

        public Teacher(string fullName) : base(fullName) {}

        public new string GetFullInfo() // new теперь этот метод приоритетный
        {
            return $"{Id},{FullName},{Age}";
        }
        public override void MakeWork()
        {
            // какая-то конкретная реализация
        }
        public override string ToString()
        {
            return GetFullInfo(); 
        }

        public override void ToDo()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person teacher = new Teacher("Ирина Павлова");
            Person student = new Student("Иван Иванов");

            Person[] people = new Person[] { teacher, student };

            foreach(var person in people)
            {
                if(person is Teacher)
                {
                    // ((Teacher)person).SubjectName = "Математика";
                    (person as Teacher).SubjectName = "Математика";
                }
                else if(person is Student)
                {
                    (person as Student).AverageMark = 4.7;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qutardayqutarrrrr.Models
{
    internal class Students
    {
       private int id;
       private string name;
       private string surname;
       private int GroupNumber;


        public void ToalInfo(int id, string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }

      
        public static int StudentsNumbers { get; set; } = 234;

        public Students()
        {
            GroupNumber = StudentsNumbers++;
            //Console.WriteLine(StudentsNumbers);
            //Console.WriteLine(GroupNumber);
        }
        public void PrintInfo()
        {

            Console.WriteLine("Group name: " + GroupNumber);
            Console.WriteLine("\tid     : " + id);
            Console.WriteLine("\tname  : " + name);
            Console.WriteLine("\tsurname      : " + surname);


        }



    }
}

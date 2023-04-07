using Qutardayqutarrrrr.Models;

namespace Qutardayqutarrrrr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Students[] students= new Students[2];

            students[0] = new Students();
            students[1] = new Students();

            Group[] groups= new Group[2];
            students[0].ToalInfo(132, "Sadiq", "Bhagiyev");
            students[0].PrintInfo();

            students[1].ToalInfo(122, "Ferrux", "Aliyev");
            students[1].PrintInfo();
            ///Console.WriteLine(Group.GroupNumbers);
            //Console.WriteLine(Students.StudentsNumbers);
            //students[0].PrintInfo();
        }
    }
}
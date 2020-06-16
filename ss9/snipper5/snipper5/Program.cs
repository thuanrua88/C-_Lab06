using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper5
{
    class university
    {
        private static string department;
        private static string universityName;
        public static string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public static string UniversityName
        {
            get
            {
                return universityName;
            }
            set
            {
                universityName = value;
            }
        }
    }
    class Physics
    {
        static void Main(string[] args)
        {
            university.UniversityName = "University";
            university.Department = "Physics";
            Console.WriteLine("UniName: " + university.UniversityName);
            Console.Read();
        }
    }
}

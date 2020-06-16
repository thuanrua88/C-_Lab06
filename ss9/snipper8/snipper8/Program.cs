using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper8
{
    class Employee
    {
        public string name
        {
            get; set;
        }
        public int Age
        {
            get; set;
        }
        public string Designation
        {
            get; set;
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.name = "john";
            emp.Age = 24;
            emp.Designation = "Ducnhu";
            Console.WriteLine("Name: {0}, Age: {1}, Designation: {2}", emp.name, emp.Age, emp.Designation);
            Console.Read();
        }
    }
}

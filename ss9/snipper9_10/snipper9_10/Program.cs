using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper9_10
{

    class Employee
    {
        //Snipper 9
        public float Age { get; private set; }
        public int Salary { private get; set; }
        
        //snipper10
        public string Name { get; set; }
        public int age { get; set; }
        public string Designation { get; set; }
        static void Main(string[] args)
        {
            Employee obj = new Employee
            {
                Name = "Jog",
                age = 24,
                Designation = "Ducnhu"
            };
            Console.WriteLine("name: {0}, age: {1}, desi: {2}", obj.Name, obj.age, obj.Designation);
            Console.Read();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper12
{
    class EmployeeDetails
    {
        public string[] empName = new string[2];
        public string this[int index]
        {
            get
            {
                return empName[index];
            }
            set
            {
                empName[index] = value;
            }
        }
        static void Main(string[] args)
        {
            EmployeeDetails obj = new EmployeeDetails();
            obj[0] = "jack";
            obj[1] = "kte";
            Console.WriteLine("Employee name:");
            for(int i = 0; i <2;i++)
            {
                Console.Write(obj[i] + "\t");
            }
            Console.Read();
        }
    }
}

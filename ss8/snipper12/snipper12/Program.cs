using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper12
{
    class SalaryDetails
    {
        private string empName;
        public string EmployeeName
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
            }
        }
        static void Main(string[] args)
        {
            SalaryDetails obj = new SalaryDetails();
            obj.EmployeeName = "DucNhudai";
            Console.WriteLine("Employee name: " + obj.EmployeeName);
            Console.Read();
        }
    }
}

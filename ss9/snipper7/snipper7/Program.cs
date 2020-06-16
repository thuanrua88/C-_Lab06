using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper7
{
    class Employee
    {
        string empName;
        int empID;
        float salary;

        public string EmpName
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
        public int empID
        {
            get
            {
                return empID;
            }
            set
            {
                empID = value;
            }
        }
        public float salary
        {
            get
            {
                return salary;
            }
            set
            {
                if(value < 0)
                {
                    salary = 0;
                }
                else
                {
                    salary = value;
                }
            }
        }
    }

    class Salary : Employee
    {
        static void Main(string[] args)
        {
        }
    }
}

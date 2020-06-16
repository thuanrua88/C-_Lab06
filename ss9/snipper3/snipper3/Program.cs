using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper3
{
    class Department
    {
        string deptName;
        int deptID;
        public string DeptName
        {
            set
            {
                deptName = value;
            }
        }
        public int DeptID
        {
            set
            {
                deptID = value;
            }
        }
        public void Display()
        {
            Console.WriteLine("Department Name: " + deptName);
            Console.WriteLine("Department ID: " + deptID); }

    }
    class Company
    {
        static void Main(string[] args)
        {
            Department obj = new Department();
            obj.DeptID = 201;
            obj.DeptName = "21";
            obj.Display();
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper11
{
    interface ISet
    {
        void AcceptDetails(int valOne, string Valtwo);
    }
    interface IGet
    {
        void Display();
    }
    class Employee : ISet
    {
        int empID;
        string empName;
        public void AcceptDetails(int valOne, string valTwo) {
            empID = valOne;
            empName = valTwo;
        }
        static void Main(string[] args)
        {
            Employee objEmpl = new Employee();
            objEmpl.AcceptDetails(10, "jack");
            IGet objIG = objEmpl as IGet;
            if (objIG != null) {
                objIG.Display();
            }
            else
            {
                Console.WriteLine("Invalid casting occurred");
            }

        }
    }
}

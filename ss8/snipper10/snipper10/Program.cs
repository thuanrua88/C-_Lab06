using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper10
{
    interface ICalculate
    {
        double Area();
    }
    class Rectangle : ICalculate
    {
        float length;
        float breadth;
        public Rectangle(float valOne, float valTwo)
        {
            length = valOne;
            breadth = valTwo;
        }
        public double Area()
        {
            return length * breadth; 
        }
    
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle(10.2f, 20.2f);
            if(obj is ICalculate)
            {
                Console.WriteLine("Area of Rectangle: {0:F2}", obj);
            }
            else
            {
                Console.WriteLine("Interface method not implemented");
            }
            Console.Read();
        }
    }
}

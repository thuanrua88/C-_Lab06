using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper6
{
    public abstract class Figure
    {
        public abstract int DimensionOne
        {
            set;
        }
        public abstract int DimensionTwo
        {
            set;
        }
    }
    class Rectangle : Figure
    {
        int dismensionOne;
        int dimensiontwo;
        public override int DimensionOne
        {
            set
            {
                if(dismensionOne<=0)
                {
                    dismensionOne = 0;
                }
                else
                {
                    dismensionOne = value;
                }
            }
        }
        public override int DimensionTwo
        {
            set
            {
                if (dimensiontwo <= 0)
                {
                    dimensiontwo = 0;
                }
                else
                {
                    dimensiontwo = value;
                }
            }
        }
        int Area()
        {
            return dismensionOne * dimensiontwo;
        }
        static void Main(string[] args)
        {
            Rectangle obj = new Rectangle();
            obj.DimensionOne = 20;
            obj.DimensionTwo = 10;
            Console.WriteLine("Area of: " + obj.Area());
            Console.Read();
        }
    }
}

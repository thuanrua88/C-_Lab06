using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper9
{
    interface IMath
    {
        void Area();
    }
    class Circle : IMath
    {
        public const float PI = 3.14f;
        protected float Radius;
        protected double AreaOfCircle;

        public virtual void Area()
        {
            AreaOfCircle = (PI * Radius * Radius);
        }
    }
    class Sphere : Circle
    {
        double areaOfSphere;
        public override void Area()
        {
            base.Area();
            areaOfSphere = (AreaOfCircle * 4);
        }
        static void Main(string[] args)
        {
            Sphere obj = new Sphere();
            obj.Radius = 7;
            obj.Area();
            Console.WriteLine("Area of Sphere: {0:F2}", obj.areaOfSphere);
            Console.Read();
        }
    }
}

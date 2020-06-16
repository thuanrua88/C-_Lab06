using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper11
{
    class Car
    {
        string carType;
        public virtual string CarType
        {
            get
            {
                return carType;
            }
            set
            {
                carType = value;
            }
        }
    }

    class Ferrari : Car
    {
        string carType;
        public override string CarType
        {
            get
            {
                return base.CarType;
            }
            set
            {
                base.CarType = value;
                carType = value;
            }
        }
        static void Main(string[] args)
        {
            Car obj = new Car();
            obj.CarType = "Utility";
            Ferrari obj2 = new Ferrari();
            obj2.carType = "Car";
            Console.WriteLine("cartype:" + obj.CarType);
            Console.WriteLine("Ferrari: " + obj.CarType);
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper8
{
    interface IReptile: ICarnivorous, IAnimal
    {
         void Habitat();
    }
    interface ICarnivorous
    {
        void Eat();
    }
    interface IAnimal
    {
        void Drink();
    }
    class Crocodile : IReptile {
        public void Drink()
        {
            Console.Write("Drinks fresh water");
        }
        public void Eat()
        {
            Console.Write("Drinks fresh water");
        }
        public void Habitat()
        {
            Console.Write("Drinks fresh water");
        }

        static void Main(string[] args) {
            Crocodile objCrocodile = new Crocodile();
            Console.WriteLine(objCrocodile.GetType().Name);

            Console.WriteLine(objCrocodile.GetType().Name); objCrocodile.Habitat(); objCrocodile.Eat(); objCrocodile.Drink();
            Console.Read();
        }
    }
}

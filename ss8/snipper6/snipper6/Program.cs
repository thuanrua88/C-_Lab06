using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper6
{
    interface ITerrestrialAnimal
    {
        void Eat();
    }
    interface IMarineAnimal
    {
        void Swim();
    }
    class Corodile : ITerrestrialAnimal, IMarineAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The Crocodile flesh");
        }
        public void Swim()
        {
            Console.WriteLine("can swim");
        }


        static void Main(string[] args)
        {
            Corodile obj = new Corodile();
            obj.Eat();
            obj.Swim();
            Console.Read();
        }
    }
}

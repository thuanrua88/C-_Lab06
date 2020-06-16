using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper5
{
    interface IAnimal
    {
        void Habitat();
    }
    class Dog : IAnimal
    {
        public void Habitat()
        {
            Console.WriteLine("My Home");
        }
        static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.Habitat();
            Console.Read();
            
        }
    }
}

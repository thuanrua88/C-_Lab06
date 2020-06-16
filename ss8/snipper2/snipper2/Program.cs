using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper2
{
    abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats food in order to survive");
        }
        public abstract void AnimalSound();
    }

    class Lion : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Lion roars");
        }
        static void Main(string[] args)
        {
            Lion obj = new Lion();
            Console.Read();
        }
    }
}

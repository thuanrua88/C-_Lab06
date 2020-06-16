using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper1
{
    public abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats food in order to survive");
        }
        public abstract void AnimalSound();
        public abstract void habitat();
    }
    interface iAnimal
    {
        void habita();
    }
    class myCat : iAnimal
    {
        void iAnimal.habita()
        {
            Console.WriteLine("Mew Mew");
        }
        static void Main()
        {
            iAnimal obj = new myCat();
            obj.habita();
            Console.Read();
        }
    }

}

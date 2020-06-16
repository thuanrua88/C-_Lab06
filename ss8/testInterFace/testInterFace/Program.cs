using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testInterFace
{
    interface fish
    {
        void fishpig();
    }
    interface Habitat
    {
        void fishhabitat();
    }
    class myFish : Habitat, fish
    {
        void Habitat.fishhabitat()
        {
            Console.WriteLine("Water");
        }
        void fish.fishpig()
        {
            Console.WriteLine("Ca Heo");
        }
        static void Main(string[] args)
        {
            Habitat ha = new myFish();
            ha.fishhabitat();
            Console.Read();
        }
    }
}

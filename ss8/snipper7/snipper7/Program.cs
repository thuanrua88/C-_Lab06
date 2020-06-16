using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper7
{
    interface IterrestrialAnimal
    {
        string Eat();
    }
    interface IMrineAnimal
    {
        string Eat();
    }
    class Crocodile : IterrestrialAnimal, IMrineAnimal
    {
        string IterrestrialAnimal.Eat()
        {
            string terCroc = "Crocodile eats other animals";
            return terCroc;
        }
        string IMrineAnimal.Eat()
        {
            string marCroc = "Crocodile eats fish and marine animals";
            return marCroc;
        }
        public string Eatmarine()
        {
            IMrineAnimal obj;
            obj = this;
            return obj.Eat();
        }
        public string EatTerrestrial() {
            IterrestrialAnimal obj = this;
            return obj.Eat();
        }
        static void Main(string[] args)
        {
            Crocodile obj = new Crocodile();
            string terCroc = obj.EatTerrestrial();
            Console.WriteLine(terCroc);
            string marCroc = obj.Eatmarine();
            Console.WriteLine(marCroc);
            Console.Read();
        }
    }
}

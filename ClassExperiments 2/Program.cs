using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassExperiments_2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Duck duck = new Duck();

            //duck.NumberOfLegs = 4;
            //int legs = duck.NumberOfLegs;
            //Console.WriteLine(legs);
            //Console.Read();
            //duck.ColorOfFur = "brown";
            //duck.MakesSound = true;
            Genre g1 = new Genre();
            Genre g2 = new Genre();
            Genre g3 = new Genre();

            g1.Name = "hip hop";
            g2.Name="rock";
            g3.Name = "country";
            Console.WriteLine("Genres: {0},{1},{2}", g1.Name, g2.Name, g3.Name);
            Console.Read();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExperimentts
{
    class Person
    {
        //Do nothing
        public string Name;
        public int Age;
    }
    class Box
    {
        public double h, l, w;
        public double volume()
        {
            return (this.h * this.l * this.w);
        }
        public Box(double hi, double le, double wi)
        {
         this.h = hi;
         this.l = le;
         this.w = wi;
        }
        ~Box()
        {
            Console.WriteLine("This is the de-structor");
           

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Mike Dearth";
            p.Age = 65;

            Person n = new Person();
            n.Name = "Carol Ann";
            n.Age = 64;

            Person j = p;

            Box box6 = new Box(45,45,100);
            //box6.h = 50;
            //box6.w = 35;
            //box6.l = 49;
            Console.WriteLine("Volume of Box6 is {0}", box6.volume());
            //Console.ReadKey();



        }
    }
}

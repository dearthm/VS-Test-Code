using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExperiments_2
{
   public class Animal
    {
        public int NumberOfLegs { get; set;}
        public string ColorOfFur { get; set; }
    }
    public class Duck : Animal
    {
        public bool canFly { get; set; }
        public bool MakesSound { get; set; }


    }
}

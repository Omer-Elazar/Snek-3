using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snek
{
    public abstract class Food : Circle // all consumables
    {

        public Random random { get; set; }

        public Food()
        { 
            random = new Random();
        }

        ~Food() { }
        public abstract void Eat();
        

    }
}

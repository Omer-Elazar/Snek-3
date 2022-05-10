using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;

namespace Snek
{
    public class AppleList
    {
        public SortedList Apples;

        public AppleList() 
        {
            Apples = new SortedList();
            Apples[Apples.Count] = new Apple();
        }

        public Apple this[int index]
        {
            get
            {
                if (index >= Apples.Count)
                    return (Apple)null;
                return (Apple)Apples.GetByIndex(index);
            }
            set
            {
                if (index <= Apples.Count)
                    Apples[index] = value;		
            }
        }
    }
}

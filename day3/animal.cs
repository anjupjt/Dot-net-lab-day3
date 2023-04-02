using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
 public abstract class animal 
    {
        public void WhatIeat()
        {
            Console.WriteLine("I eat grass");

        }
        public abstract void WhatIeat(string food);
        //{
        //    Console.WriteLine("I eat " + food);
        //}
        public void WhatIeat(string food1, string food2)
        {
            Console.WriteLine("I eat " + food1 +" and " + food2);
        }
    }
        public class Cow : animal
        {
            public override void WhatIeat(string food)
            {
                Console.WriteLine("I eat "+ food);
            }
        }
}

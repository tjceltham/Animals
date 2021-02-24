using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Snake : Animal
    {
       public Snake() : base(0)
        {
            Console.WriteLine("Snake constructed");

        }

       

        public override void move()
        {

            Console.WriteLine("Slither Slither");
        }
        public override void eat()
        {
            Console.WriteLine("Gulp down small rodent");
        }



    }
}

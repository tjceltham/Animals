using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Dog : Animal
    {
        public Dog() : base(4)
        {
            Console.WriteLine("Dog created");

        }

        public override void move()
        {

            Console.WriteLine("Only when a stick has been thrown");
        }
        public override void eat() {
            Console.WriteLine("Only when feed");
        }


    }
}

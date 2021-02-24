using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    abstract class Animal
    {

        private int legs;

        public Animal(int l)
        {
            Console.WriteLine("Animal Created");
            legs = l;
        }

        public abstract void move();
        public abstract void eat();



        public void breath()
        {
            Console.WriteLine("pant pant");
        }
       
    }
}

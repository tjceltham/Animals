using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Animal d = new Snake();
            Animal s = new Snake();

            Animal[] a = new Animal[5];
            
            for(int x=0;x<5; x++)
            {
                if (Console.ReadLine() == "D") a[x] = new Dog(); else a[x] = new Snake();
            }

            for(int x=0; x< 5; x++)
            {
                a[x].eat();
                a[x].breath();
            }
            





        }
    }
}

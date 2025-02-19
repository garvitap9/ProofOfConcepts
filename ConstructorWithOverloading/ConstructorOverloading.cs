using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorWithOverloading
{
    public class ConstructorOverloading
    {
        public static int Number1 {  get; set; }
        public static int Number2 { get; set; }

        public ConstructorOverloading(int numBer) 
        { 
            Number1 = numBer;
        }

        public ConstructorOverloading()
        {
            Number2 = 42;
        }

        public static void DisplayNumbers()
        {
            Console.WriteLine("Exploring the concept of Constructor and constructor overloading in a simple way");
            Console.WriteLine("Number1: "+Number1);
            Console.WriteLine("Number2: " + Number2);
        }
    }
}

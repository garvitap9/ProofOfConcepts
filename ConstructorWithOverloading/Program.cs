using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorWithOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstructorOverloading constructorOverloading1 = new ConstructorOverloading(99);
            ConstructorOverloading constructorOverloading2 = new ConstructorOverloading();
            ConstructorOverloading.DisplayNumbers();
        }
    }
}

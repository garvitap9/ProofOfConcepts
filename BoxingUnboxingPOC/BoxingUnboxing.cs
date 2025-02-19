using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxingPOC
{
    public class BoxingUnboxing
    {
        public static void IntBoxingUnboxing()
        {
            int numberOne = 98;

            object objectOne = numberOne; //boxing
            Console.WriteLine($"Boxing int: Value type to Reference type:  {objectOne} and {objectOne.GetType()}");
            int unboxNumberOne = (int)objectOne; //unboxing
            Console.WriteLine($"UnBoxing int: Reference type to Value type:  {unboxNumberOne} and {unboxNumberOne.GetType()}");
        }

        public static void CharBoxingUnboxing()
        {
            char characterLetter = 'M';

            object objectChar = characterLetter; //boxing
            Console.WriteLine($"Boxing char: Value type to Reference type: {objectChar} and {objectChar.GetType()}");
            char unboxCharacter = (char)objectChar; //unboxing
            Console.WriteLine($"UnBoxing char: Reference type to Value type: {unboxCharacter} and {unboxCharacter.GetType()}");
        }
    }
}

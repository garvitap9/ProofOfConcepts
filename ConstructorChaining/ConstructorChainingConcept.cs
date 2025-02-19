using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    public class ConstructorChainingConcept
    {
        public ConstructorChainingConcept():this(98)
        {
            Console.WriteLine("Constructor with No argument!");
        }
        public ConstructorChainingConcept(int numBer) : this("Garvita")
        {
            Console.WriteLine("Constructor with int argument! Value: "+numBer);
        }
        public ConstructorChainingConcept(string nameStore)
        {
            Console.WriteLine("Constructor with string argument! Value: "+nameStore);
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestrictionOperators
{
    public partial class LinqSamplesRestrictionOperators
    {
        public void OfTypeLinq5A()
        {
            ArrayList fruits = new ArrayList(4) { "Mango", "Orange", "Apple", 3.0, "Banana" };

            // Apply OfType() to the ArrayList.
            IEnumerable<string> query1 = fruits.OfType<string>();

            Console.WriteLine("Elements of type 'string' are:");
            foreach (string fruit in query1)
            {
                Console.WriteLine(fruit);
            }

            // The following query shows that the standard query operators such as 
            // Where() can be applied to the ArrayList type after calling OfType().
            IEnumerable<string> query2 =
                fruits.OfType<string>().Where(fruit => fruit.ToLower().Contains("n"));

            Console.WriteLine("\nThe following strings contain 'n':");
            foreach (string fruit in query2)
            {
                Console.WriteLine(fruit);
            }

        }
    }
}

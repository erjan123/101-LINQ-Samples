using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqSamplesCommon
{
    public static class ExtensionMethods
    {
        // int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        // numbers.ForEach(x => Console.WriteLine(x));
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action )
        {
            if (action == null)
                return;

            foreach (T str in source)
                action(str);
        }
    }
}

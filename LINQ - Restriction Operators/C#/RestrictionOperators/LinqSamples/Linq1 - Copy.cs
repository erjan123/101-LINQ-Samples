//using System;
//using System.ComponentModel;
//using System.Linq;
//using System.Collections.Generic;
//using System.Collections;

//namespace RestrictionOperators
//{
//    public static class MyLinqExtensions
//    {
//        // Example 3: Even much better example
//        //public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
//        //{
//        //    foreach (T num in source)
//        //        if (predicate(num))
//        //            yield return num;
//        //}

//        //  Example 2: A Better example with Generics
//        //public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
//        //{
//        //    List<TSource> result = new List<TSource>();

//        //    foreach (TSource number in source)
//        //    {
//        //        if (predicate(number))
//        //            result.Add(number);
//        //    }

//        //    return result;
//        //}

//        // Example 1:
//        //public static IEnumerable<int> Where(this IEnumerable<int> source, Func<int, bool> predicate)
//        //{
//        //    List<int> temp = new List<int>();

//        //    foreach (var num in source)
//        //    {
//        //        if(predicate(num))
//        //            temp.Add(num);
//        //    }

//        //    return temp;
//        //}

//        // A better Example:
        
//    }

//    public partial class LinqSamplesRestrictionOperators
//    {
//        // Select all numbers greater than 5
//        [Description("This sample uses the where clause to find all elements of an array with a value less than 5.")]
//        public void Linq1()
//        {
//            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//            #region Make Sure to try yourself before looking at the code 

//                    var lowNums =
//                        from num in numbers
//                        where num < 5
//                        select num;

//                    Console.WriteLine("Numbers < 5:");
//                    foreach (var x in lowNums)
//                    {
//                        Console.WriteLine(x);
//                    } 

//            #endregion
//        }


//// **********************************************************************************************
//// ***********************************************************************************************
//        delegate void DisplayMessage(int message);
//        // delegate void DisplayAction(int message);


//        private static void DisplayNumbers(int message)
//        {
//            Console.WriteLine(message);
//        }
//        // Linq with Lambda
//        public void Linq1A()
//        {
//            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//            IEnumerable<int> lowNumsQS =
//                                from num in numbers
//                                where num < 5
//                                select num;

//            IEnumerable<int> lowNumsQS1 =
//                                   from num in numbers
//                                   where num < 5
//                                   select num;

//            DisplayMessage myDisplayMessageDelegateObject = DisplayNumbers;

//            Action<int> myActionToDisplayNumbers = DisplayNumbers;

//          //  lowNumsQS.ToList().ForEach((int number) => myDisplayMessageDelegateObject(number));
//            lowNumsQS.ToList().ForEach(delegate (int number) { Console.WriteLine(number); });
//          //  lowNumsQS.ToList().ForEach((int number) => myActionToDisplayNumbers(number));
//          //  lowNumsQS.ToList().ForEach(number => Console.WriteLine(number));

//            IEnumerator mySpecialEnumertor = lowNumsQS.GetEnumerator();
//                while(mySpecialEnumertor.MoveNext())
//                    Console.WriteLine("Yes I got it: " + mySpecialEnumertor.Current);


//            #region Make Sure to try yourself before looking at the code 


//        //    var lowNumsLambda = numbers.Where(num => num < 5);

//            //Console.WriteLine("lowNums with Lambda < 5:");
//            //    foreach (var x in lowNumsLambda)
//            //    {
//            //        Console.WriteLine(x);
//            //    }

//            #endregion
//        }
//    }
//}

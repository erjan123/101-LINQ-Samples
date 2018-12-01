using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenerationOperators;
using RestrictionOperators;
using ConversionOperators;
using ProjectionOperators;
using PartitioningOperators;
using OrderingOperators;
using GroupingOperators;
using SetOperators;
using ElementOperators;
using Quantifiers;
using CustomSequenceOperators;
using QueryExecution;
using AggregateOperators;
using MiscellaneousOperators;
using JoinOperators;

namespace _101_LINQ_Samples
{
    class Program
    { 
        static void Main(string[] args)
        {
            #region 1.Restriction Operators (Filtering)

                // "where" - Filter values based on a predicate function
                // "OfType" - Filter values based on their ability to be as a specified type

                //LinqSamplesRestrictionOperators samples_a = new LinqSamplesRestrictionOperators();

                //samples_a.Linq1();
                //samples_a.Linq1A();

                //samples_a.Linq2();
                //samples_a.Linq2A();

                //samples_a.Linq3();
                //samples_a.Linq3A();

                //samples_a.Linq4();
                //samples_a.Linq4A();

                // This sample can't be implemented with Query syntax
                //samples_a.Linq5();
                //samples_a.OfTypeLinq5A();

            #endregion RestrictionOperators

            #region 2.Projection Operators

                // Projection Operators
                // 1. "Select" - The operator projects values on basis of a transform function
                // 2. "SelectMany" - "The operator project the sequences of values which are based 
                //    on a transform function as well as flattens them into a single sequence

                // LinqSamplesProjectionOperators samples_b = new LinqSamplesProjectionOperators();

                //samples_b.DataSetLinq6();
                //samples_b.DataSetLinq6A();
                //samples_b.DataSetLinq7();
                //samples_b.DataSetLinq7A();
                //samples_b.DataSetLinq8();
                //samples_b.DataSetLinq8A();
                //samples_b.DataSetLinq9();
                //samples_b.DataSetLinq9A();
                //samples_b.DataSetLinq10();
                //samples_b.DataSetLinq10A();
                //samples_b.DataSetLinq11();
                //samples_b.DataSetLinq11A();
                //samples_b.DataSetLinq12();
                //samples_b.DataSetLinq13();
                //samples_b.DataSetLinq13A();
                //samples_b.DataSetLinq14();
                //samples_b.DataSetLinq14A();
                //samples_b.DataSetLinq15();
                //samples_b.DataSetLinq16();
                //samples_b.DataSetLinq16A();
                //samples_b.DataSetLinq17();
                //samples_b.DataSetLinq17A();
                //samples_b.DataSetLinq18();
                //samples_b.DataSetLinq18A();
                //samples_b.DataSetLinq19();
                //samples_b.DataSetLinq19A();

            #endregion

            #region 3.Partitioning Operators

                // "Skip" - Skips some specified number of elements within a sequence and returns the 
                //  remaining ones
                // "SkipWhile" - Same as that of Skip with the only exception that number of 
                // elements to skip are specified by a Boolean condition
                // "Take" - Take a specified number of elements from a sequence and skip the remaining ones
                // "TakeWhile" - Same as that of Take except the fact that number of elements to take are 
                // specified by a Boolean condition

                //LinqSamplesPartitioningOperators sample_c = new LinqSamplesPartitioningOperators();

                // sample_c.Linq20();
                // sample_c.Linq21();
                // sample_c.Linq22();
                // sample_c.Linq23();
                // sample_c.Linq23A();
                // sample_c.Linq24();
                // sample_c.Linq25();
                // sample_c.Linq26();
                // sample_c.Linq27();

            #endregion PartitioningOperators

            #region 4.Ordering Operators (Sorting Operators)

            // "OrderBy" - The operator sort values in an ascending order
            // "OrderByDescending" - The operator sort values in a descending order
            // "ThenBy" - Executes a secondary sorting in an ascending order
            // "ThenByDescending" - Executes a secondary sorting in a descending order
            // "Reverse" - Performs a reversal of the order of the elements in a collection

            // LinqSamplesOrderingOperators linqSamples_d = new LinqSamplesOrderingOperators();

            // linqSamples_d.Linq28();
            // linqSamples_d.Linq28A();
            // linqSamples_d.Linq29();
            // linqSamples_d.Linq29A();
            // linqSamples_d.Linq30();
            // linqSamples_d.Linq30A();
            // linqSamples_d.Linq31();
            // linqSamples_d.Linq32();
            // linqSamples_d.Linq32A();
            // linqSamples_d.Linq33();
            // linqSamples_d.Linq33A();
            // linqSamples_d.Linq34();
            // linqSamples_d.Linq35();
            // linqSamples_d.Linq35A();
            // linqSamples_d.Linq36();
            // linqSamples_d.Linq37();
            // linqSamples_d.Linq37A();
            // linqSamples_d.Linq38();
            // linqSamples_d.Linq39();
            // linqSamples_d.Linq39A();

            #endregion

            #region 5.Grouping Operators

            // "GroupBy" - 	Organize a sequence of items in groups and return them as an IEnumerable collection 
            // of type IGrouping<key, element>
            // "ToLookup" - Execute a grouping operation in which a sequence of key pairs are returned

            // LinqSamplesGroupingOperators samples_e = new LinqSamplesGroupingOperators();

            // samples_e.DataSetLinq40();
            // samples_e.DataSetLinq40A();
            // samples_e.DataSetLinq41();
            // samples_e.DataSetLinq41A();
            // samples_e.DataSetLinq42();
            // samples_e.DataSetLinq42A();
            // samples_e.DataSetLinq43();
            // samples_e.DataSetLinq43A();
            // samples_e.DataSetLinq44();
            // samples_e.DataSetLinq45();

            #endregion

            #region 6.Set Operators

            // "Distinct" - Results a list of unique values from a collection by filtering duplicate 
            // data if any
            // "Except" - Compares the values of two collections and return the ones from one 
            // collection who are not in the other collection
            // "Intersect" - Returns the set of values found t be identical in two separate collections
            // "Union" - Combines content of two different collections into a single list that too 
            // without any duplicate content

            // LinqSamplesSetOperators sample_f = new LinqSamplesSetOperators();

            // sample_f.Linq46();
            // sample_f.Linq47();
            // sample_f.Linq47A();
            // sample_f.Linq48();
            // sample_f.Linq49();
            // sample_f.Linq49A();
            // sample_f.Linq50();
            // sample_f.Linq51();
            // sample_f.Linq51A();
            // sample_f.Linq52();
            // sample_f.Linq53();
            // sample_f.Linq53A();

            #endregion

            #region 7.Conversion Operators

            // "AsEnumerable" - Returns the input typed as IEnumerable<T>
            // "AsQueryable" - A (generic) IEnumerable is converted to a (generic) IQueryable
            // "Cast" - Performs casting of elements of a collection to a specified type
            // "OfType" - 	Filters values on basis of their , depending on their capability 
            // to be cast to a particular type
            // "ToArray" - 	Forces query execution and does conversion of a collection to an array
            // "ToDictionary" - On basis of a key selector function set elements into a 
            // Dictionary<TKey, TValue> and forces execution of a LINQ query
            // "ToList" - Forces execution of a query by converting a collection to a List<T>
            // "ToLookup" - Forces execution of a query and put elements into a Lookup<TKey, TElement> on 
            // basis of a key selector function

            // LinqSamplesConversionOperators samples_g = new LinqSamplesConversionOperators();

            // samples_g.Linq54();
            // samples_g.Linq54A();
            // samples_g.Linq55();
            // samples_g.Linq55A();
            // samples_g.Linq56();
            // samples_g.Linq57();

            #endregion

            #region 8.Element Operators

            // "ElementAt" - Returns an element present within a specific index in a collection
            // "ElementAtOrDefault" - 	Same as ElementAt except of the fact that it also returns 
            // a default value in case the specific index is out of range
            // "First" - Retrieves the first element within a collection or the first element 
            // satisfying a specific condition
            // "FirstOrDefault" - 	Same as First except the fact that it also returns a default 
            // value in case there is no existence of such elements
            // "Last" - Retrieves the last element present in a collection or the last element 
            // satisfying a specific condition
            // "LastOrDefault" - 	Same as Last except the fact that it also returns a default 
            // value in case there is no existence of any such element
            // "Single" - Returns the lone element of a collection or the lone element that sati
            // sfy a certain condition
            // "SingleOrDefault" - Same as Single except that it also returns a default value if 
            // there is no existence of any such lone element
            // "DefaultIfEmpty" - Returns a default value if the collection or list is empty or null

            // Note: The sample 60 and 63 are missing.These are actually missing
            // from the oginal project (or site)

            // LinqSamplesElementOperators samples_h = new LinqSamplesElementOperators();

            // samples_h.Linq58();
            // samples_h.Linq58A();
            // samples_h.Linq59();
            // samples_h.Linq61();
            // samples_h.Linq62();
            // samples_h.Linq64();
            // samples_h.Linq64A();

            #endregion

            #region 9.Generation Operators

            // "DefaultIfEmpty" - When applied to an empty sequence, generate a default element 
            // within a sequence
            // "Empty" - Returns an empty sequence of values and is the most simplest generational operator
            // "Range" - Generates a collection having a sequence of integers or numbers
            // "Repeat" - Generates a sequence containing repeated values of a specific length

            // LinqSamplesGenerationOperators samples_i = new LinqSamplesGenerationOperators();

            // samples_i.Linq65();
            // samples_i.Linq65A();
            // samples_i.Linq66();

            #endregion

            #region 10.Quantifiers

            // "All" - Returns a value ‘True’ if all elements of a sequence satisfy a predicate condition
            // "Any" - Determines by searching a sequence that whether any element of the same 
            // satisfy a specified condition
            // "Contains" - 	Returns a ‘True’ value if finds that a specific element is there in a 
            // sequence if the sequence doe not contains that specific element , ‘false’ value is returned


            // Note: The sample 68 and 71 are missing.These are actually missing
            // from the oginal project (or site)

            // LinqSamplesQuantifiers samples_j = new LinqSamplesQuantifiers();

            // samples_j.Linq67();
            // samples_j.Linq69();
            // samples_j.Linq69A();
            // samples_j.Linq70();
            // samples_j.Linq72();
            // samples_j.Linq72A();

            #endregion

            #region 11.Aggregate Operators

            // "Aggregate" - Operates on the values of a collection to perform custom aggregation operation 
            // "Average" - Average value of a collection of values is calculated 
            // "Count" - Counts the elements satisfying a predicate function within collection
            // "LonCount" - Counts the elements satisfying a predicate function within a huge collection
            // "Max" - Find out the maximum value within a collection
            // "Min" - Find out the minimum value existing within a collection
            // "Sum" - Find out the sum of a values within a collection

            //LinqSamplesAggregateOperators samples_k = new LinqSamplesAggregateOperators();

            //samples_k.Linq73();
            //samples_k.Linq74();
            //samples_k.Linq76();
            //samples_k.Linq76A();
            //samples_k.Linq77();
            //samples_k.Linq77A();
            //samples_k.Linq78();
            //samples_k.Linq79();
            //samples_k.Linq80();
            //samples_k.Linq80A();
            //samples_k.Linq81();
            //samples_k.Linq82();
            //samples_k.Linq83();
            //samples_k.Linq83A();
            //samples_k.Linq84();
            //samples_k.Linq84A();
            //samples_k.Linq85();
            //samples_k.Linq86();
            //samples_k.Linq87();
            //samples_k.Linq87A();
            //samples_k.Linq88();
            //samples_k.Linq88A();
            //samples_k.Linq89();
            //samples_k.Linq90();
            //samples_k.Linq91();
            //samples_k.Linq91A();
            //samples_k.Linq92();
            //samples_k.Linq93();

            #endregion

            #region 12.Miscellaneous Operators

            // "Concat" - Two sequences are concatenated for the formation of a single one sequence.
            // "EqualAll" - To see if two sequences match on all elements in the same order

            //LinqSamplesMiscellaneousOperators samples_l = new LinqSamplesMiscellaneousOperators();

            //samples_l.Linq94();
            //samples_l.Linq95();
            //samples_l.Linq95A();
            //samples_l.Linq96();
            //samples_l.Linq97();

            #endregion

            #region 13.Custom Sequence Operators

            // "Combine" - 
            //LinqSamplesCustomSequenceOperators samples_m = new LinqSamplesCustomSequenceOperators();

            //samples_m.DataSetLinq98();

            #endregion

            #region 14.Query Execution

            // "Deferred Execution" - 
            // "Immediate Execution" - 
            // "Query Reuse" - 

            //LinqSamplesQueryExecution samples_n = new LinqSamplesQueryExecution();

            //samples_n.Linq99();
            //samples_n.Linq100();
            //samples_n.Linq101();

            #endregion

            #region 15.Join Operators 

            // "Join" - The operator join two sequences on basis of matching keys
            // "Group Join" - Join two sequences and group the matching elements
            // "Cross Join" 
            // "Left Outer Join"

            //LinqSamplesJoinOperators samples_o = new LinqSamplesJoinOperators();

            //samples_o.Linq102();
            //samples_o.Linq102A();
            //samples_o.Linq103();
            //samples_o.Linq103A();
            //samples_o.Linq104();
            //samples_o.Linq104A();
            //samples_o.Linq105();
            //samples_o.Linq105A();
            //samples_o.Linq106();
            //samples_o.Linq106A();
            //samples_o.Linq107();
            //samples_o.Linq107A();

            #endregion

            Console.ReadKey();
        }
    }
}

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
            #region 1.RestrictionOperators (Filtering)
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

            #region 2.ProjectionOperators

            // Projection Operators
            // 1. "Select" - The operator projects values on basis of a transform function
            // 2. "SelectMany" - "The operator project the sequences of values which are based 
            // on a transform function as well as flattens them into a single sequence

            LinqSamplesProjectionOperators samples_b = new LinqSamplesProjectionOperators();

            //samples_b.DataSetLinq6();
            //samples_b.DataSetLinq6A();
            //samples_b.DataSetLinq7();
            //samples_b.DataSetLinq7A();
            //samples_b.DataSetLinq8();
            //samples_b.DataSetLinq8A();

             samples_b.DataSetLinq9();
             samples_b.DataSetLinq9A();
            // samples_b.DataSetLinq10();
            // samples_b.DataSetLinq11();
            // samples_b.DataSetLinq12();
            // samples_b.DataSetLinq13();
            // samples_b.DataSetLinq14();
            // samples_b.DataSetLinq15();
            // samples_b.DataSetLinq16();
            // samples_b.DataSetLinq17();
            // samples_b.DataSetLinq18();
            // samples_b.DataSetLinq19();

            #endregion

            #region 3.PartitioningOperators

            // LinqSamplesPartitioningOperators sample_c = new LinqSamplesPartitioningOperators();

            // sample_c.Linq20();
            // sample_c.Linq21();
            // sample_c.Linq22();
            // sample_c.Linq23();
            // sample_c.Linq24();
            // sample_c.Linq25();
            // sample_c.Linq26();
            // sample_c.Linq27();

            #endregion PartitioningOperators

            #region 4.OrderingOperators

            // LinqSamplesOrderingOperators linqSamples_d = new LinqSamplesOrderingOperators();
            // 
            // linqSamples_d.Linq28();
            // linqSamples_d.Linq29();
            // linqSamples_d.Linq30();
            // linqSamples_d.Linq31();
            // linqSamples_d.Linq31();
            // linqSamples_d.Linq32();
            // linqSamples_d.Linq33();
            // linqSamples_d.Linq34();
            // linqSamples_d.Linq35();
            // linqSamples_d.Linq36();
            // linqSamples_d.Linq37();
            // linqSamples_d.Linq38();
            // linqSamples_d.Linq39();

            #endregion

            #region 5.GroupingOperators

            // LinqSamplesGroupingOperators samples_e = new LinqSamplesGroupingOperators();

            // samples_e.DataSetLinq40();
            // samples_e.DataSetLinq41();
            // samples_e.DataSetLinq42();
            // samples_e.DataSetLinq43();
            // samples_e.DataSetLinq44();
            // samples_e.DataSetLinq45();

            #endregion

            #region 6.SetOperators

            // LinqSamplesSetOperators sample_f = new LinqSamplesSetOperators();

            // sample_f.Linq46();
            // sample_f.Linq47();
            // sample_f.Linq48();
            // sample_f.Linq49();
            // sample_f.Linq50();
            // sample_f.Linq51();
            // sample_f.Linq52();
            // sample_f.Linq53();

            #endregion

            #region 7.Conversion Operators

            // LinqSamplesConversionOperators samples_g = new LinqSamplesConversionOperators();

            // samples_g.Linq54();
            // samples_g.Linq55();
            // samples_g.Linq55();
            // samples_g.Linq57();

            #endregion

            #region 8.Element Operators

            // Note: The sample 60 and 63 are missing.These are actually missing
            // from the oginal project (or site)

            // LinqSamplesElementOperators samples_h = new LinqSamplesElementOperators();

            // samples_h.Linq58();
            // samples_h.Linq59();
            // samples_h.Linq61();
            // samples_h.Linq62();
            // samples_h.Linq64();

            #endregion

            #region 9.Generation Operators

            // LinqSamplesGenerationOperators samples_i = new LinqSamplesGenerationOperators();

            // samples_i.Linq65();
            // samples_i.Linq66();

            #endregion

            #region 10.Quantifiers
            // Note: The sample 68 and 71 are missing.These are actually missing
            // from the oginal project (or site)

            // LinqSamplesQuantifiers samples_j = new LinqSamplesQuantifiers();

            // samples_j.Linq67();
            // samples_j.Linq69();
            // samples_j.Linq70();
            // samples_j.Linq72();

            #endregion

            #region 11.Aggregate Operators

            // LinqSamplesAggregateOperators samples_k = new LinqSamplesAggregateOperators();
            // 
            // samples_k.Linq73();
            // samples_k.Linq74();
            // samples_k.Linq76();
            // samples_k.Linq77();
            // samples_k.Linq78();
            // samples_k.Linq79();
            // samples_k.Linq80();
            // samples_k.Linq81();
            // samples_k.Linq82();
            // samples_k.Linq83();
            // samples_k.Linq84();
            // samples_k.Linq85();
            // samples_k.Linq86();
            // samples_k.Linq87();
            // samples_k.Linq88();
            // samples_k.Linq89();
            // samples_k.Linq90();
            // samples_k.Linq91();
            // samples_k.Linq92();
            // samples_k.Linq93();

            #endregion

            #region 12.Miscellaneous Operators

            // LinqSamplesMiscellaneousOperators samples_l = new LinqSamplesMiscellaneousOperators();
            // 
            // samples_l.Linq94();
            // samples_l.Linq95();
            // samples_l.Linq96();
            // samples_l.Linq97();

            #endregion

            #region 13.Custom Sequence Operators

            // LinqSamplesCustomSequenceOperators samples_m = new LinqSamplesCustomSequenceOperators();

            //samples_m.DataSetLinq98();

            #endregion

            #region 14.Query Execution

            //LinqSamplesQueryExecution samples_n = new LinqSamplesQueryExecution();

            //samples_n.Linq99();
            //samples_n.Linq100();
            //samples_n.Linq101();


            #endregion

            #region 15.Join Operators 

            // LinqSamplesJoinOperators samples_o = new LinqSamplesJoinOperators();
            // 
            // samples_o.Linq102();
            // samples_o.Linq103();
            // samples_o.Linq104();
            // samples_o.Linq105();
            // samples_o.Linq106();
            // samples_o.Linq107();

            #endregion

            Console.ReadKey();
        }
    }
}

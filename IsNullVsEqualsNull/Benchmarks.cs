using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace IsNullVsEqualsNull
{
    [MemoryDiagnoser]
    [RankColumn, AllStatisticsColumn, MinColumn, MaxColumn, StdDevColumn, MedianColumn]
    public class Benchmarks
    {
        [Params(1, 100, 1000, 10000, 100000)]
        public int Count { get; set; }

        private bool?[] _values;
        
        [GlobalSetup]
        public void Setup()
        {
            var random = new Random(Count);

            _values = new bool?[Count];
            
            for (var index = 0; index < _values.Length; index++)
            {
                _values[index] = random.Next(0, 2) == 0 ? null : random.Next(0, 2) == 0;
            }
        }
        
        [Benchmark]
        public void IsNull()
        {
            var _ = _values.Count(value => value is null);
        }

        [Benchmark]
        public void EqualsNull()
        {
            var _ = _values.Count(value => value == null);
        }
    }
}
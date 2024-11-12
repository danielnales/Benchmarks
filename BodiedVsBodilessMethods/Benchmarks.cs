using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BodiedVsBodilessMethods
{
    [MemoryDiagnoser]
    [RankColumn, AllStatisticsColumn, MinColumn, MaxColumn, StdDevColumn, MedianColumn]
    public class Benchmarks
    {
        [Params(10, 100, 1000, 10000, 100000)]
        public int Count { get; set; }
        
        private int[] _values;
        
        [GlobalSetup]
        public void Setup()
        {
            var random = new Random(Count);

            _values = Enumerable.Range(0, Count).ToArray();
        }
        
        [Benchmark]
        public void BodiedMethods()
        {
            var _ = 0;
            
            for (var index = 0; index < _values.Length - 1; index++)
            {
                _ += BodiedImplementation(_values[index], _values[index + 1]);
            }
        }

        [Benchmark]
        public void BodilessMethods()
        {
            var _ = 0;
            
            for (var index = 0; index < _values.Length - 1; index++)
            {
                _ += BodilessImplementation(_values[index], _values[index + 1]);
            }
        }

        private int BodilessImplementation(int x, int y) => x * y;

        private int BodiedImplementation(int x, int y)
        {
            return x * y;
        }
    }
}
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using Trials.Fibonacci;

namespace Trials.Benchmark
{
    [SimpleJob]
    public class BenchmarkExecuter
    {
        private FibonacciTest _fibonacciTest;

        [Params(3,4,7)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            _fibonacciTest = new FibonacciTest();
        }

        [Benchmark]
        public int Fibonacci()
        {
            return _fibonacciTest.PrintFibsWithDictionary(N);
        }
    }

   

   
}

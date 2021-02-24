using NUnit.Framework;
using System.Collections.Generic;

namespace Fibonacci.Tests
{
    public class FibonacciTestCases
    {
        public Fibonacci fb;
        [SetUp]
        public void Setup()
        {
            fb = new Fibonacci();
        }

        [Test]
        public void Does_It_Return_Fibonacci()
        {
            var ExpectedResult = new List<int>() { 0, 1, 1, 2, 3, 5 };
            var result = fb.FibonacciSeries(6);
            for(var i = 0;i < result.Count; i++)
            {
                if(result[i] != ExpectedResult[i])
                {
                    Assert.Fail("Not a Fibonacci Series function");
                    break;
                }
            }
            Assert.Pass("Fibonacci Series function works perfectly");
        }

        [Test]
        public void Does_It_Return_3_Items()
        {
            var ExpectedResult = new List<int>() { 0, 1, 1 };
            var result = fb.FibonacciSeries(3);
            for (var i = 0; i < result.Count; i++)
            {
                if (result[i] != ExpectedResult[i])
                {
                    Assert.Fail("Not a Fibonacci Series function");
                    break;
                }
            }
            Assert.Pass("Fibonacci Series function works perfectly");

        }
    }
}
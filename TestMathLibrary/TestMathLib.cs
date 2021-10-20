using System;
using Xunit;

namespace TestMathLibrary
{
    public class TestMathLib
    {
        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(-3, -1, -2)]
        public void TestAdd(int ans, int a, int b)
        {
            Assert.Equal(ans, MathLibrary.MathLib.Add(a, b));
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(6, 3, 2)]
        [InlineData(10, 5, 2)]
        [InlineData(100, 20, 5)]
        [InlineData(10000, 1000, 10)]
        [InlineData(0, 40938174, 0)]
        public void TestMult(int ans, int a, int b)
        {
            Assert.Equal(ans, MathLibrary.MathLib.Mult(a, b));
        }


        [Fact]
        public void TestPI()
        {
            //fact
            Assert.Equal(3.1415926m, MathLibrary.MathLib.PI);
        }
    }
}

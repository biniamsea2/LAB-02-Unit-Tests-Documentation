using System;
using Xunit;
using static LAB02UnitTests.Program;

namespace Lab02banktest
{
    public class UnitTest1
    {
        [Fact]
        public void BalanceTest()
        {
            Assert.Equal(100000, View(100000));
        }

        [Fact]
        public void DepositTest()
        {
            Assert.Equal(500, View(100500));
        }



    }
}

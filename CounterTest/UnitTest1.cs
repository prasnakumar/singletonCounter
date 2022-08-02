using Singleton;
using System;
using Xunit;

namespace CounterTest
{
    public class UnitTest1
    {
        Counter_singleton counter = Counter_singleton.ObjectCreate;

        [Fact]

        public Boolean Test1()
        {
            var value = counter.Increment(3);
            return value.Equals("$3");

        }
        [Fact]
        public  void decrement()
        {

            var value = counter.Decrement(8);
            Assert.Equal("$-5", value);// this is because only one instance is created 
        }
    }
}

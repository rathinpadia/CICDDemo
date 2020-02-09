using System;
using Xunit;
using CiCdLib;
namespace CiCd.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Message msg = new Message();
            Assert.Equal("Hello World", msg.CreateMessage());
        }
    }
}

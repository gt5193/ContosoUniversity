using Xunit;

namespace ContosoUniversity.Test
{
    public class MyTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }
        [Fact]
        public void Test2()
        {
            Assert.True(false);
        }
    }
}
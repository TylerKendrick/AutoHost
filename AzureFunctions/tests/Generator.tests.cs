using NUnit.Framework;

namespace AutoHost.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            AutoHost.Hosting.FunctionHost.Result();
            Assert.Pass();
        }
    }
}
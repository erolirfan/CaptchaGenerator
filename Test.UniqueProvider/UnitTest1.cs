using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using UniqueProvider.Generators;
namespace Test.UniqueProvider
{
    [TestClass]
    public class GeneratorTest
    {
        [TestMethod]
        public void TestDefault()
        {
            Generator gen = new Generator();
            Assert.IsNotNull(gen.Generate(10));
        }
        [TestMethod]
        public void TestTimeDefault()
        {
            TimeGenerator gen = new TimeGenerator();
            Assert.IsNotNull(gen.Generate(10));
        }
        [TestMethod]
        public void TestOutsourceDefault()
        {
            OutsourceGenerator gen = new OutsourceGenerator();
            Assert.IsNotNull(gen.Generate(10));
        }
        [TestMethod]
        public void TestForValue()
        {
            MockGenerator gen = new MockGenerator(5);
            Assert.AreEqual(gen.Generate(10),
                "kjiwq7e8vd");
        }
    }
}

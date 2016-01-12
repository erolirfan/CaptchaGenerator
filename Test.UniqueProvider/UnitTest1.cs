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
            Assert.IsNotNull(gen.Generate());
        }
        [TestMethod]
        public void TestTimeDefault()
        {
            TimeGenerator gen = new TimeGenerator();
            Assert.IsNotNull(gen.Generate());
        }
        [TestMethod]
        public void TestForValue()
        {
            MockGenerator gen = new MockGenerator(5);
            Assert.AreEqual(gen.Generate(), 
                "726643700");
        }
    }
}

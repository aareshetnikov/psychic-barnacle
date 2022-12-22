using NUnit.Framework;
using ConsoleApp;

namespace TestProject
{
    public class Tests
    {
        [Test]
        // [Ignore("This test is disabled")]
        public static void TestOne()
        {
            Assert.AreEqual(Program.Factorial(5), 120);
        }

        [Test]
        // [Ignore("This test is disabled")]
        public static void TestTwo()
        {
            Assert.AreEqual(Program.Factorial(3), 6);
        }

        [Test]
        // [Ignore("This test is disabled")]
        public static void TestThree()
        {
            Assert.AreEqual(Program.Factorial(4), 24);
        }
    }
}
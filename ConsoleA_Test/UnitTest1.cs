using NUnit.Framework;
using ConsoleA;

namespace ConsoleA_Test
{
    [TestFixture]
    public class Tests
    {
        FizzBuzz buzz = null;
        [SetUp]
        public void Setup()
        {
            buzz = new FizzBuzz();
        }

        [Test]
        public void LaskeKahdenLuvunSumma()
        {
            Laskin OmaLaskin = new Laskin();
            int summa = OmaLaskin.LaskeSumma(20, 4);
            Assert.AreEqual(24, summa);
        }
        [Test]
        public void FizzBuzzTesti()
        {
            Assert.AreEqual(buzz.DoFizzBuzz(1), "1");
        }
        [Test]
        public void FizzBuzzTesti1()
        {
            Assert.AreEqual(buzz.DoFizzBuzz(3), "Fizz");            
        }
        [Test]
        public void FizzBuzzTesti2()
        {
            Assert.AreSame(buzz.DoFizzBuzz(5), "Buzz");
        }
        [Test]
        public void FizzBuzzTesti3()
        {
            Assert.AreSame(buzz.DoFizzBuzz(15), "FizzBuzz");
        }
    }
}
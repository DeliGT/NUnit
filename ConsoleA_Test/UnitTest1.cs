using NUnit.Framework;
using ConsoleA;
using System;

namespace ConsoleA_Test
{
    [TestFixture]
    public class Tests
    {
        FizzBuzz buzz = null;
        MerkkijonoLaskin laskin = null;
        [SetUp]
        public void Setup()
        {
            buzz = new FizzBuzz();
            laskin = new MerkkijonoLaskin();
        }

        [Test]
        public void LaskeKahdenLuvunSumma()
        {
            Laskin OmaLaskin = new Laskin();
            int summa = OmaLaskin.LaskeSumma(20, 4);
            Assert.AreEqual(24, summa);
        }

        // FizzBuzz Testit
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

        // Merkkijonolaskin testit
        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(0, laskin.Laske(null));
        }

        [Test]
        public void OneNumber()
        {
            Assert.AreEqual(1, laskin.Laske("1"));
        }

        [Test]
        public void TwoNumbersSeparatedWithCommaAndCommas()
        {
            Assert.AreEqual(8, laskin.Laske("3,5"));
            Assert.AreEqual(23, laskin.Laske("3,5,7,8"));
        }

        [Test]
        public void TwoNumbersSeparatedWithNewLineAndNewLines()
        {
            Assert.AreEqual(8, laskin.Laske("3\n5"));
            Assert.AreEqual(23, laskin.Laske("3\n5\n7\\n8"));
        }


        [Test]
        public void MultipleNumbersSeparatedWithNewLinesAndCommas()
        {
            Assert.AreEqual(26, laskin.Laske("3\n5,7\n8,3"));
            Assert.AreEqual(29, laskin.Laske("3\n5,7\n8,3\\n3"));
        }

        [Test]
        public void NegativesInteger()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                laskin.Laske("-2");
            });
        }

        [Test]
        public void ContainsNegativeInteger()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                laskin.Laske("3,2\n-1");
            });
        }

        [Test]
        public void OverOneThousand()
        {
            Assert.AreEqual(3, laskin.Laske("3,1001"));
        }

    }
}
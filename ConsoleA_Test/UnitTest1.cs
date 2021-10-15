using NUnit.Framework;
using ConsoleA;
using System;
using System.Collections.Generic;

namespace ConsoleA_Test
{
    [TestFixture]
    public class Tests
    {
        FizzBuzz buzz = null;
        MerkkijonoLaskin JonoLaskin = null;
        LaskinPro laskin = null;
        Laskin OmaLaskin = null;

        [SetUp]
        public void Setup()
        {
            buzz = new FizzBuzz();
            JonoLaskin = new MerkkijonoLaskin();
            laskin = new LaskinPro();
            OmaLaskin = new Laskin();
        }

        [Test]
        public void LaskeKahdenLuvunSumma()
        {
            Laskin OmaLaskin = new Laskin();
            int summa = OmaLaskin.LaskeSumma(20, 4);
            Assert.AreEqual(24, summa);
        }

        // FizzBuzz Testit / Osio 2
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

        // Merkkijonolaskin testit / Osio 3
        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(0, JonoLaskin.Laske(null));
        }

        [Test]
        public void OneNumber()
        {
            Assert.AreEqual(1, JonoLaskin.Laske("1"));
        }

        [Test]
        public void TwoNumbersSeparatedWithCommaAndCommas()
        {
            Assert.AreEqual(8, JonoLaskin.Laske("3,5"));
            Assert.AreEqual(23, JonoLaskin.Laske("3,5,7,8"));
        }

        [Test]
        public void TwoNumbersSeparatedWithNewLineAndNewLines()
        {
            Assert.AreEqual(8, JonoLaskin.Laske("3\n5"));
            Assert.AreEqual(23, JonoLaskin.Laske("3\n5\n7\\n8"));
        }


        [Test]
        public void MultipleNumbersSeparatedWithNewLinesAndCommas()
        {
            Assert.AreEqual(26, JonoLaskin.Laske("3\n5,7\n8,3"));
            Assert.AreEqual(29, JonoLaskin.Laske("3\n5,7\n8,3\\n3"));
        }

        [Test]
        public void NegativesInteger()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                JonoLaskin.Laske("-2");
            });
        }

        [Test]
        public void ContainsNegativeInteger()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                JonoLaskin.Laske("3,2\n-1");
            });
        }

        [Test]
        public void OverOneThousand()
        {
            Assert.AreEqual(3, JonoLaskin.Laske("3,1001"));
        }

        // Omat Testit / Osio 4
        [Test]
        public void OmatTestit1()
        {
            Assert.That(laskin.Guess_equation(laskin.Add(10, 10), 20), Is.True);
        }
        [Test]
        public void OmatTestit2()
        {
            Assert.True(laskin.Guess_equation(laskin.Add(15, 10), 25));
        }
        [Test]
        public void OmatTestit3()
        {
            Assert.False(laskin.Guess_equation(laskin.Add(15, 10), 22));
        }
        [Test]
        public void OmatTestit4()
        {
            Assert.That(laskin.Guess_equation(laskin.Add(15, 10), 25));
        }
        [Test]
        public void OmatTestit5()
        {
            Assert.That(25, Is.EqualTo(laskin.Add(15, 10)));
        }
        [Test]
        public void OmatTestit6()
        {
            Assert.That(27, Is.GreaterThan(laskin.Add(15, 10)));
        }
        [Test]
        public void OmatTestit7()
        {
            Assert.That(20, Is.LessThan(laskin.Add(15, 10)));
        }
        [Test]
        public void OmatTestit8()
        {
            Assert.That(26, Is.Not.LessThan(laskin.Add(15, 10)));
        }
        [Test]
        public void OmatTestit9()
        {
            var list = new List<int>();
            Assert.That(list, Is.Empty);
        }
        [Test]
        public void OmatTestit10()
        {
            var list = new List<int>();
            list.Add(10);
            Assert.That(list, Is.Not.Empty);
        }
        [Test]
        public void OmatTestit11()
        {
            string kissa = null;
            Assert.That(kissa, Is.Null);
        }
        [Test]

        public void OmatTestit12()
        {
            Assert.Throws<NullReferenceException>( () => laskin.Multiply(0,0), "Laskutoimitus on turha.");
        }
        [Test]
        public void OmatTestit13()
        {
            Assert.That(() => laskin.Multiply(0, 1), Throws.Nothing);
        }
    }
}
using NUnit.Framework;
using ConsoleA;

namespace ConsoleA_Test
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LaskeKahdenLuvunSumma()
        {
            Laskin OmaLaskin = new Laskin();
            int summa = OmaLaskin.LaskeSumma(20, 4);
            Assert.AreEqual(24, summa);
        }
    }
}
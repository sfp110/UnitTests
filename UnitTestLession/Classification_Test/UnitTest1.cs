using NUnit.Framework;
using CodeTest;


namespace Classification_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10)]
        [TestCase(11)]
        [TestCase(12)]
        public void AgeBetween10And12Excluded(int age)
        {
            Assert.That(Program
                .AvailableClassifications(age), Is.EqualTo("U & PG films are available."));
        }

        [TestCase(13)]
        [TestCase(14)]
        [TestCase(15)]
        public void AgeBetween13And15Excluded(int age)
        {
            Assert.That(Program
                .AvailableClassifications(age), Is.EqualTo("U, PG & 12 films are available."));
        }

        [TestCase(16)]
        [TestCase(17)]
        [TestCase(18)]
        public void AgeBetween15And18Excluded(int age)
        {
            Assert.That(Program
                .AvailableClassifications(age), Is.EqualTo("U, PG, 12 & 15 films are available."));
        }

        [TestCase(17)]
        [TestCase(18)]
        [TestCase(19)]
        public void AgeBetween17And19(int age)
        {
            Assert.That(Program
                .AvailableClassifications(age), Is.EqualTo("All films are available."));
        }
    }
}
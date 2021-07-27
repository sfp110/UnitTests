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

        [TestCase(11)]
        [TestCase(14)]
        [TestCase(15)]
        [TestCase(18)]
        public void GivenAgeOf11(int age)
        {
            Assert.That(Program
                .AvailableClassifications(age), Is.EqualTo("U & PG films are available."));
        }

        [TestCase(11)]
        [TestCase(14)]
        [TestCase(15)]
        [TestCase(18)]
        public void GivenAgeOf14(int age)
        {
            Assert.That(Program
                .AvailableClassifications(age), Is.EqualTo("U, PG & 12 films are available."));
        }

        [TestCase(11)]
        [TestCase(14)]
        [TestCase(15)]
        [TestCase(18)]
        public void GivenAgeOf15(int age)
        {
            Assert.That(Program
                .AvailableClassifications(age), Is.EqualTo("U, PG, 12 & 15 films are available."));
        }

        [TestCase(11)]
        [TestCase(14)]
        [TestCase(15)]
        [TestCase(18)]
        public void GivenAgeOf18(int age)
        {
            Assert.That(Program
                .AvailableClassifications(age), Is.EqualTo("All films are available."));
        }
    }
}
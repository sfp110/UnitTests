using NUnit.Framework;
using CodeTest;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenATimeOf21_Greeting_RetunrsGoodEvening()
        {
            var time = 21;
            var expectedGreeting = "Good Evening";

            var result = Program.Greeting(time);

            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
    }
}
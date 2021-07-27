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
        public void GivenATimeOf3_Greeting_RetunrsGoodEvening()
        {
            var time = 3;
            var expectedGreeting = "Go to bed!";

            var result = Program.Greeting(time);

            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        [Test]
        public void GivenATimeOf12_Greeting_RetunrsGoodEvening()
        {
            var time = 12;
            var expectedGreeting = "Good Morning";

            var result = Program.Greeting(time);

            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        [Test]
        public void GivenATimeOf16_Greeting_RetunrsGoodEvening()
        {
            var time = 16;
            var expectedGreeting = "Good Afternoon";

            var result = Program.Greeting(time);

            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        [Test]
        public void GivenATimeOf21_Greeting_RetunrsGoodEvening()
        {
            var time = 21;
            var expectedGreeting = "Good Evening";

            var result = Program.Greeting(time);

            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        [Test]
        public void GivenATimeOf25_Greeting_RetunrsGoodEvening()
        {
            var time = 25;
            var expectedGreeting = "Error.";

            var result = Program.Greeting(time);

            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
    }
}
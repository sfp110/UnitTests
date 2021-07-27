using NUnit.Framework;
using CodeTest;
using NUnit.Framework.Internal;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(3)]
        [TestCase(12)]
        [TestCase(16)]
        [TestCase(21)]    
        [TestCase(25)]

        // Test Case #1: Expected Greeting to match the time provided : Verification
        public void GivenATimeOf3_Greeting_RetunrsGoToBed(int time)
        {
            //Arrange
            var expectedGreeting = "Go to bed!";

            //Act
            var result = Program.Greeting(time);

            //Assert
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        //[Test]
        [TestCase(3)]
        [TestCase(12)]
        [TestCase(16)]
        [TestCase(21)]
        [TestCase(25)]
        // Test Case #2: Expected Greeting to match the time provided : Verification
        public void GivenATimeOf12_Greeting_RetunrsGoodMorning(int time)
        {
            var expectedGreeting = "Good Afternoon";

            var result = Program.Greeting(time);

            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        //[Test]
        [TestCase(3)]
        [TestCase(12)]
        [TestCase(16)]
        [TestCase(21)]
        [TestCase(25)]
        // Test Case #3: Expected Greeting to match the time provided : Verification
        public void GivenATimeOf16_Greeting_RetunrsGoodAfternoon(int time)
        {
            var expectedGreeting = "Good Afternoon";

            var result = Program.Greeting(time);

            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
        //[Test]
        [TestCase(3)]
        [TestCase(12)]
        [TestCase(16)]
        [TestCase(21)]
        [TestCase(25)]
        // Test Case #4: Expected Greeting to match the time provided : Verification
        public void GivenATimeOf21_Greeting_RetunrsGoodEvening(int time)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo("Good Evening"));
        }
        //[Test]
        [TestCase(3)]
        [TestCase(12)]
        [TestCase(16)]
        [TestCase(21)]
        [TestCase(25)]
        // Test Case #5: Expected Greeting to match the time provided : Verification
        public void GivenATimeOf25_Greeting_RetunrsError(int time)
        {
            var expectedGreeting = "Error.";

            var result = Program.Greeting(time);

            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
    }
}
using ECS.Legacy;
using NUnit.Framework;

namespace ECS.Legacy.Test.Unit
{
    public class Tests
    {
        private FakeHeater _heater;
        private FakeTempSensor _tempSensor;
        private ECS _uut;

        [SetUp]
        public void Setup()
        {
            _heater = new FakeHeater();
            _tempSensor = new FakeTempSensor();
            _uut = new ECS(_tempSensor, _heater, 25);
        }


        [TestCase(25,25)]
        [TestCase(24,24)]
        [TestCase(-5,-5)]
        [TestCase(0,0)]

        public void Temp_TempIsCorrect_SetTempIsEqualToGetTemp(int temp, int result)
        {
            
            // Act

            _tempSensor.Temperature = temp;

            // Assert

            Assert.That(_tempSensor.GetTemp(),Is.EqualTo(result));
        }

        [Test]

        public void Heater_IsTurnedOn_TurnOnAmountCorrect()
        {
            // Act

            _tempSensor.Temperature = 20;

            _uut.Regulate();

            // Assert

            Assert.That(_heater.TurnOnActivated,Is.EqualTo(1));
        }

        [Test]

        public void Heater_IsTurnedOff_TurnOffAmountCorrect()
        {
            // Act

            _tempSensor.Temperature = 30;

            _uut.Regulate();

            // Assert

            Assert.That(_heater.TurnOffActivated,Is.EqualTo(1));
        }
    }
}
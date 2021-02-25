using ECS.Legacy;
using NSubstitute;
using NUnit.Framework;

// testing dummy peter
namespace ECS.Legacy.Test.Unit
{
    public class Tests
    {
        private IHeater _heater;
        private ITempSensor _tempSensor;
        private ECS _uut;

        [SetUp]
        public void Setup()
        {
            _heater = Substitute.For<IHeater>();
            _tempSensor = Substitute.For<ITempSensor>();
            _uut = new ECS(_tempSensor, _heater, 25);
        }


        [Test]

        public void Heater_IsTurnedOn_TurnOnAmountCorrect()
        {
            // Act

            _tempSensor.GetTemp().Returns(24);

            _uut.Regulate();

            // Assert
            _heater.Received(1).TurnOn();
            // Assert.That(_heater.TurnOnActivated,Is.EqualTo(1));
        }

        [Test]

        public void Heater_IsTurnedOff_TurnOffAmountCorrect()
        {
            // Act

            _tempSensor.GetTemp().Returns(26);

            _uut.Regulate();

            // Assert
            _heater.Received(1).TurnOff();
            // Assert.That(_heater.TurnOffActivated, Is.EqualTo(1));
        }

        [Test]

        public void RunSelfTest_SelfTestReturnsTrue()
        {
            // Act

            _tempSensor.RunSelfTest().Returns(true);
            _heater.RunSelfTest().Returns(true);

            Assert.IsTrue(_uut.RunSelfTest());
            // Assert
        }

        [TestCase(true,false)]
        [TestCase(false,true)]

        public void RunSelfTest_SelfTestReturnsFalse(bool a, bool b)
        {
            // Act

            _tempSensor.RunSelfTest().Returns(a);
            _heater.RunSelfTest().Returns(b);

            Assert.IsFalse(_uut.RunSelfTest());
            // Assert
        }

        [Test]

        public void GetCurrentTemp_TempIsCorrect()
        {

            // Act
            _tempSensor.GetTemp().Returns(25);

            // Assert

            Assert.That(_uut.GetCurTemp(),Is.EqualTo(25));
        }

        [Test]

        public void SetThreshold_ThresholdIsSetCorrect()
        {

            // Act
            _uut.SetThreshold(20);

            Assert.That(_uut.GetThreshold(),Is.EqualTo(20));
        }

        
    }
}
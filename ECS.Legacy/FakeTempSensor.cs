using System;

namespace ECS.Legacy
{
    public class FakeTempSensor : ITempSensor
    {
        private int temperature;

        public int Temperature
        {
            get
            {
                return this.temperature;
            }
            set
            {
                this.temperature = value;
            }
        }

        public FakeTempSensor()
        {
            temperature = 0;
        }

        public int GetTemp()
        {
            return temperature;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
using System;

namespace ECS.Legacy
{
    public class FakeTempSensor : ITempSensor
    {
        private int temperature;

        public int Temperature { get; set; }
        

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
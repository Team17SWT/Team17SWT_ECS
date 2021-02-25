using System;

namespace ECS.Legacy
{
    public class FakeTempSensor : ITempSensor
    {
        public int Temperature { get; set; }

        public FakeTempSensor()
        {
            Temperature = 0;
        }

        public int GetTemp()
        {
            return Temperature;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
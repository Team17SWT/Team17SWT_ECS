namespace ECS.Legacy
{
    public class FakeHeater : IHeater
    {
        private int turnOnActivated;
        private int turnOffActivated;

        public int TurnOnActivated { get; set; }
        

        public int TurnOffActivated { get; set; }


        

        public FakeHeater()
        {
            turnOffActivated = 0;
            turnOnActivated = 0;
        }

        public void TurnOn()
        {
            ++turnOnActivated;
        }

        public void TurnOff()
        {
            ++turnOffActivated;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
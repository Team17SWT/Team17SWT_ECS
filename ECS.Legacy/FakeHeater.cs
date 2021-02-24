namespace ECS.Legacy
{
    public class FakeHeater : IHeater
    {
        private int turnOnActivated;
        private int turnOffActivated;

        public int TurnOnActivated
        {
            get
            {
                return this.turnOnActivated;
            }
            set
            {
                this.turnOnActivated = value;
            }
        }

        public int TurnOffActivated
        {
            get
            {
                return this.turnOffActivated;
            }
            set
            {
                this.turnOffActivated = value;
            }
        }

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
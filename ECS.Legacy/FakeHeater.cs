namespace ECS.Legacy
{
    public class FakeHeater : IHeater
    {
        
        public int TurnOnActivated { get; set; }
        

        public int TurnOffActivated { get; set; }



        public FakeHeater()
        {
            TurnOffActivated = 0;
            TurnOnActivated = 0;
        }

        public void TurnOn()
        {
            ++TurnOnActivated;
        }

        public void TurnOff()
        {
            ++TurnOffActivated;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
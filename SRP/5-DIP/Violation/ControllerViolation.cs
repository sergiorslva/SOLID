namespace SOLID.DIP.Violation
{
    public class ControllerViolation
    {
        private readonly FanViolation fanViolation;

        public ControllerViolation(FanViolation fanViolation)
        {
            this.fanViolation = fanViolation;
        }

        public void On()
        {

            fanViolation.On();
        }

        public void Off()
        {
            fanViolation.Off();
        }
        
    }
}

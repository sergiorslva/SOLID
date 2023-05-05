namespace SOLID.DIP.Solution
{
    public class ControllerSolution
    {
        private readonly IDeviceSolution deviceSolution;

        public ControllerSolution(IDeviceSolution deviceSolution)
        {
            this.deviceSolution = deviceSolution;
        }

        public void On()
        {
            deviceSolution.On();
        }

        public void Off()
        {
            deviceSolution.Off();
        }
    }
}

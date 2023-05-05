namespace SOLID.LSP.Solution
{
    public class HREmployeeSolution : AbstractHREmployeeSolution
    {
        public override double CalcutePayment()
        {
            return 0;
        }
        
        public override void HireNewEmployee()
        {
            Console.WriteLine("Hire someone");
        }
    }
}

namespace SOLID.LSP.Violation
{
    public class HREmployeeViolation : EmployeeViolation
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

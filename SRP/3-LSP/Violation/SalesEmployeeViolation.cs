namespace SOLID.LSP.Violation
{
    public class SalesEmployeeViolation : EmployeeViolation
    {
        public override double CalcutePayment()
        {
            return 0;
        }

        public override void HireNewEmployee()
        {
            //This is a violation
            throw new NotImplementedException();
        }
    }
}

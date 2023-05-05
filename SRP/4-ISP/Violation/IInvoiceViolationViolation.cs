namespace SOLID.ISP.Violation
{
    public interface IInvoiceViolationViolation
    {
        public void SendMail();
        public bool GetCustomer();
        public void CreateInvoice();
    }
}

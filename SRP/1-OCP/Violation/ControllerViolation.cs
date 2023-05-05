namespace SOLID.OCP.Violation
{
    public class ControllerViolation
    {
        public void PrintToWeb()
        {
            List<InvoiceModel> invoices = GetInvoices();
            Console.WriteLine("Print to Web");
        }

        public void PrintToPDF()
        {
            List<InvoiceModel> invoices = GetInvoices();
            Console.WriteLine("Print to PDF");
        }

        private List<InvoiceModel> GetInvoices()
        {
            InvoiceDataMock invoiceDataMock = new InvoiceDataMock();
            return invoiceDataMock.GetInvoices();
        }
    }
}

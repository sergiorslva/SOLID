namespace SOLID.OCP.Solution
{
    public class ControllerSolution
    {
        private readonly IPrintInvoiceSolution _printInvoice;

        public ControllerSolution(IPrintInvoiceSolution printInvoice)
        {
            this._printInvoice = printInvoice;
        }

        public void PrintInvoice()
        {
            InvoiceDataMock invoiceDataMock = new InvoiceDataMock();
            List<InvoiceModel> invoices = invoiceDataMock.GetInvoices();

            _printInvoice.PrintInvoice(invoices);
        }
    }
}

namespace SOLID.OCP.Solution
{
    public class PrintToPDFSolution : IPrintInvoiceSolution 
    {
        public void PrintInvoice(List<InvoiceModel> invoices)
        {
            Console.WriteLine("Printing PDF");
        }
    }
}

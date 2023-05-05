namespace SOLID.OCP.Solution
{
    public class PrintToWebSolution : IPrintInvoiceSolution
    {
        public void PrintInvoice(List<InvoiceModel> invoices)
        {
            Console.WriteLine("Printing to WEB");
        }
    }
}

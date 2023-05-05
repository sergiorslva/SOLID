namespace SOLID.OCP
{
    public class InvoiceModel
    {
        public int Id { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
    }
}

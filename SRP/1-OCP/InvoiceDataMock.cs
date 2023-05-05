namespace SOLID.OCP
{
    public class InvoiceDataMock
    {
        public List<InvoiceModel> GetInvoices()
        {
            return new List<InvoiceModel>()
            {
                new InvoiceModel()
                {
                    Id = 1,
                    DueDate = DateTime.Now.AddMonths(1),
                    InvoiceDate = DateTime.Now,
                    Total = 100,
                    TotalPaid = 0
                },
                new InvoiceModel()
                {
                    Id = 1,
                    DueDate = DateTime.Now,
                    InvoiceDate = DateTime.Now.AddMonths(2),
                    Total = 200,
                    TotalPaid = 50
                }
            };
        }
    }
}

namespace VerySimpleInvoicing.Desktop.Entities
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int ItemNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }

        public Invoice Invoice { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace VerySimpleInvoicing.Desktop.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime IssuedOn { get; set; }
        public DateTime DeliveredOn { get; set; }
        public int DueInDays { get; set; }
        public int PaymentMethodId { get; set; }
        public string IBAN { get; set; }
        public string Currency { get; set; }
        public string PONumber { get; set; }
        public string OrderNumber { get; set; }

        public Customer Customer { get; set; }
        public Supplier Supplier { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
    }
}

namespace VerySimpleInvoicing.Desktop.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string StreetAndHouseNo { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string BusinessId { get; set; }
        public string TaxId { get; set; }
        public string VATRegNo { get; set; }
        public string SignedIn { get; set; }
        public string StampImagePath { get; set; }
    }
}

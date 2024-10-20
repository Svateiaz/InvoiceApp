namespace ReactApp2.Server.Models
{
    public class Invoice
    {

        public int Id { get; set; }
        public int SupplierId { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }
        public int StatusId { get; set; }
        public int Quantity { get; set; }
        public int Total {  get; set; }
        public DateTime InvoiceDT { get; set; }
    }
}

namespace ReactApp2.Server.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string StreetAddress { get; set; }
        public string PostCode { get; set; }
        public int UserId { get; set; }
       
    }
}

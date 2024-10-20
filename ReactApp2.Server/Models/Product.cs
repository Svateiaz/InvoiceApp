namespace ReactApp2.Server.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UnitPrice { get; set; }
        public int SupplierId { get; set; }
        public int IsDeleted { get; set; }
        public DateTime DT { get; set; }

    }
}


namespace ReactApp2.Server.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDT { get; set; }

    }
}

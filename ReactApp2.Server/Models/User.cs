using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReactApp2.Server.Models
{
    public class User
    {
        [Column("ID")]  // Ensure that the column name matches exactly, including case
        public int Id { get; set; }

        [Column("USERNAME")]  // Match the column name case
        public required string Username { get; set; }
    }
}

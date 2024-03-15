using System.ComponentModel.DataAnnotations;

namespace billing.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Contract_Number { get; set; }
        public DateTime? Last_Update { get; set; }
    }
}

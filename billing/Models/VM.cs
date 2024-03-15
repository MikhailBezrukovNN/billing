using System.ComponentModel.DataAnnotations;

namespace billing.Models
{
    public class VM
    {
        public string? Name { get; set; }
        public int? Cpu { get; set; }
        public decimal? Ram { get; set; }
        public decimal? Ssd { get; set; }
        public decimal? Hdd { get; set; }
        public string? Ip { get; set; }
        public int? Client_Id { get; set; }
        [Key]
        public string Key { get; set; }
        public decimal? Cost { get; set; } = 0;
        public DateTime? ChangeDate { get; set; } = DateTime.Now;

        public Client Client { get; set; }
    }
}

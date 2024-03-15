using System.ComponentModel.DataAnnotations;

namespace billing.Models
{
    public class VMsHistory
    {
        public string? Name { get; set; }
        public int? Cpu { get; set; }
        public decimal? Ram { get; set; }
        public decimal? Ssd { get; set; }
        public decimal? Hdd { get; set; }
        public string? Ip { get; set; }
        public int? ClientId { get; set; }
        public DateTime? Change_Date { get; set; } = DateTime.Now;
        [Key]
        public string Key { get; set; }
        public decimal? Cost { get; set; } = 0;
        public string? Comment { get; set; }

        public Client Client { get; set; }
    }
}

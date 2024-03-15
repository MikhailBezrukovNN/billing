using Microsoft.EntityFrameworkCore;
using billing.Models; // Используйте пространство имен, где находятся ваши модели

namespace billing.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<VM> VMs { get; set; }
        public DbSet<VMsHistory> VMsHistories { get; set; }

        // Остальная часть контекста базы данных
    }
}
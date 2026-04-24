using Microsoft.EntityFrameworkCore;
using InvoiceAPI.Models;

namespace InvoiceAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<InvoiceItem> Items { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
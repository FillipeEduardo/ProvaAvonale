using Microsoft.EntityFrameworkCore;
using ProvaAvonale.Models;

namespace ProvaAvonale.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Estoque> Estoques { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}
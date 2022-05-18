using Microsoft.EntityFrameworkCore;
using ProvaAvonale.Data.Mappings;
using ProvaAvonale.Models;

namespace ProvaAvonale.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProdutoModel>? Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}
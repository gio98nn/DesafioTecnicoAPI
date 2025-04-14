using Microsoft.EntityFrameworkCore;
using ProdutosApi.Models;
using System.Text.Json;

namespace ProdutosApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(p => p.Fotos)
                .HasConversion(
                    fotos => JsonSerializer.Serialize(fotos, (JsonSerializerOptions?)null),
                    json => JsonSerializer.Deserialize<List<string>>(json, (JsonSerializerOptions?)null) ?? new List<string>()
                );

        }
    }
}

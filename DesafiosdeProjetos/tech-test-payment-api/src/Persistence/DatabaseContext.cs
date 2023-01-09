using Microsoft.EntityFrameworkCore;
using src.Models;

namespace src.Persintence;

public class DatabaseContext : DbContext{

    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        
    }

    public DbSet<Item> Itens { get; set; }
    public DbSet<Venda> Vendas { get; set; }
    public DbSet<Vendedor> Vendedores { get; set; }

    protected override void OnModelCreating(ModelBuilder builder){
        builder.Entity<Venda>(table => {
            table.HasKey(e => e.id);
            table
                .HasMany(e => e.itens)
                .WithOne()
                .HasForeignKey(c => c.vendaId);
        });

        builder.Entity<Item>(table => {
            table.HasKey(e => e.id);
        });
        
    }
}
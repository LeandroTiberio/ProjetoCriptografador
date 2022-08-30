using Criptografador.data.Models;
using Microsoft.EntityFrameworkCore;

namespace Criptografador.data.Data
{
    public class CriptografadorContext : DbContext
    {
        public CriptografadorContext(DbContextOptions options) : base (options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Restaurante>().ToTable("restautantes");
            modelBuilder.Entity<Restaurante>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Restaurante>()
                        .HasOne(x => x.Produto) //Indica a propriedade do relacionamento One = 1 Many = N                 
                        .WithMany(x => x.Restaurantes)
                        .HasForeignKey(x => x.IdRestaurantes);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cliente>().ToTable("clientes");
            modelBuilder.Entity<Cliente>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Cliente>()
                        .HasOne(x => x.Pedido)                     
                        .WithMany(x => x.Clientes)
                        .HasForeignKey(x => x.IdClientes);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entregador>().ToTable("clientes");
            modelBuilder.Entity<Entregador>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Entregador>()
                        .HasOne(x => x.Pedido)                     
                        .WithMany(x => x.Entregadores)
                        .HasForeignKey(x => x.IdEntregadores);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pedido>().ToTable("pedidos");
            modelBuilder.Entity<Pedido>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Pedido>()
                        .HasOne(x => x.PedidoXProduto)                     
                        .WithMany(x => x.Pedidos)
                        .HasForeignKey(x => x.IdPedidos);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>().ToTable("produtos");
            modelBuilder.Entity<Produto>().HasKey(key => key.Id); //Indica a propriedade da chave primaria, no caso Id
            modelBuilder.Entity<Produto>()
                        .HasOne(x => x.PedidoXProduto)                     
                        .WithMany(x => x.Produtos)
                        .HasForeignKey(x => x.IdProdutos);




        } 
        public DbSet<Restaurante> Restaurante { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Entregador> Entregador { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Produto> Produto { get; set; }
    }
}
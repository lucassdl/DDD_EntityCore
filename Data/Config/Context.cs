using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Config
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemDoPedido> ItensDoPedido { get; set; }
    }
}

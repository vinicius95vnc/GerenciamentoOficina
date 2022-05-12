using GerenciamentoOficina.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoOficina.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Moto> Moto { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Venda> Venda { get; set; }
    }
}

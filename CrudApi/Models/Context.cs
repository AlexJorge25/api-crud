using Microsoft.EntityFrameworkCore;

namespace CrudApi.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Categorias> Categoria { get; set; } = null!;
        public DbSet<Produto> Produto { get; set; } = null!;
        public DbSet<User> usuarios { get; set; }

    }
}

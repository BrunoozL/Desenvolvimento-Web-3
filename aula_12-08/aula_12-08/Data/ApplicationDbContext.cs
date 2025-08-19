using Microsoft.EntityFrameworkCore;
using aula_12_08.Models;

namespace aula_12_08.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Produto> Produtos { get; set; }
    }
}

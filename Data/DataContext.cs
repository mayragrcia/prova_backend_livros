using provaLivro.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{   
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){  }

        public DbSet<Livro> Livro { get; set; }
    }
}
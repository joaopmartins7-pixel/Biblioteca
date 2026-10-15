using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Livro> Livros { get; set; }
    }
}

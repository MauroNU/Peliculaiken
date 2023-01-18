using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Peliculas.Models;

namespace Peliculaiken.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Pelicula> Peliculas { get; set; }
    }
}


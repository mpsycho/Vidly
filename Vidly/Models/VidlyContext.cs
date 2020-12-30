using System.Data.Entity;

namespace Vidly.Models
{
    public class VidlyContext : DbContext
    {
        //Entities
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
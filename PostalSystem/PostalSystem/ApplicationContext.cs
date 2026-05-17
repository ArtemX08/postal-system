using Microsoft.EntityFrameworkCore;

namespace PostalSystem
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<PostOffice> PostOffices { get; set; }

        public ApplicationContext()
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PostalSystemDB;Trusted_Connection=True;");
        }
    }
}
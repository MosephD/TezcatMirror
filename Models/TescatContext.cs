using Microsoft.EntityFrameworkCore;
using Tescat1.Models.Data;

namespace Tescat1.Models
{
    public class TescatContext : DbContext
    {
        public TescatContext(
          DbContextOptions<TescatContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Pc> PC { get; set; }

        public DbSet<UserCredential> User_Credentials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Especificar que la propiedad 'IdUser' es la clave primaria de la entidad 'User'
            modelBuilder.Entity<User>()
                .HasKey(u => u.ID_USER);

            modelBuilder.Entity<Pc>().HasKey(p => p.ID_PC);

            modelBuilder.Entity<UserCredential>().HasKey(p => p.ID_CREDENTIALS);
        }


    }
}

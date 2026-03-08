using API_Hexagonal_DOTNET.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_Hexagonal_DOTNET.Data.Contexts
{
    public class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public Context(DbContextOptions<Context> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasKey(stdt => stdt.Registry);

            base.OnModelCreating(modelBuilder);

        }
    }
}

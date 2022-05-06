using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.DataAccess
{
    public class TestDbContext : DbContext
    {

        public DbSet<Person> Persons { get; set; }

        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasData(

                new Person()
                {
                    Name = "Micke",
                    Age = 32,
                    Id = 1
                }


                );
        }

    }
}

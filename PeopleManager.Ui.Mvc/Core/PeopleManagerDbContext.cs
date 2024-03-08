using Microsoft.EntityFrameworkCore;
using PeopleManager.Ui.Mvc.Models;

namespace PeopleManager.Ui.Mvc.Core
{
    public class PeopleManagerDbContext: DbContext
    {
        public PeopleManagerDbContext(DbContextOptions<PeopleManagerDbContext> options) : base(options)
        {
            
        }

        public DbSet<Person> People => Set<Person>();

        public void Seed()
        {
            People.AddRange(new List<Person>
            {
                new Person { FirstName = "John", LastName = "Doe", Email = "johndoe@example.com" },
                new Person { FirstName = "Jane", LastName = "Smith" }, // Email not specified
                new Person { FirstName = "Michael", LastName = "Johnson", Email = "michaeljohnson@example.com" },
                new Person { FirstName = "Emily", LastName = "Jones" }, // Email not specified
                new Person { FirstName = "Chris", LastName = "Brown", Email = "chrisbrown@example.com" },
                new Person { FirstName = "David", LastName = "Wilson" }, // Email not specified
                new Person { FirstName = "Olivia", LastName = "Taylor", Email = "oliviataylor@example.com" },
                new Person { FirstName = "Daniel", LastName = "Moore" }, // Email not specified
                new Person { FirstName = "Amanda", LastName = "Anderson", Email = "amandaanderson@example.com" },
                new Person { FirstName = "James", LastName = "Thomas", Email = "jamesthomas@example.com" }
            });

            SaveChanges();
        }
    }
}

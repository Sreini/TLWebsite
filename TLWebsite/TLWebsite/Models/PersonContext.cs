using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TLWebsite.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person
                {

                });
        } 

        public DbSet<Person> Person { get; set; }

        public DbSet<Photo> Photo { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Certificate> Certificates { get; set; }

    }
}

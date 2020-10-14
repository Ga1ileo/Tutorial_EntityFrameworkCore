using Microsoft.EntityFrameworkCore;
using Tutorial_EntityFrameworkCore.Models;
using System;


namespace Tutorial_EntityFrameworkCore.DAL
{
    public class SchoolContext :DbContext
    {
        public DbSet<Student> Students {get; set;}
        public DbSet<Course> Courses {get; set;}

        public DbSet<Person> Persons {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite(@"Server = .\SqlExpress; Database = SchoolDB; Trusted_Connection = True; ");
        }

        //Example of modelBuilder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //With this configurations I force to colocate the primary key manually "Just to Person's entity"
            modelBuilder.Entity<Person>().Property(p => p.personId).HasColumnName("Id").HasDefaultValue(0).IsRequired();

            //shadow property
            modelBuilder.Entity<Person>().Property<String>("Ocupacion");
            modelBuilder.Entity<Person>().Property<int>("Edad");
        }
    }
}
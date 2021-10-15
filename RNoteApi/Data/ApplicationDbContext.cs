using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RNoteApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Note>().HasData(
                new Note() { Id = 1, Title = "Sample Note 1", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." },
                new Note() { Id = 2, Title = "Sample Note 2", Content = "Sed et luctus dolor, eget ullamcorper urna." });
        }
    }
}

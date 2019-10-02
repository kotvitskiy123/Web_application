using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Entities;

namespace WebApplication5
{
    public class ObjectivesContext : DbContext
    {
        public ObjectivesContext(DbContextOptions<ObjectivesContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //builder.UseSqlServer("Data Source=.;Initial Catalog=Objective;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ObjectiveTag>()
                .HasKey(t => new { t.ObjectiveId, t.TagID });

            modelBuilder.Entity<ObjectiveTag>()
                .HasOne(sc => sc.Objective)
                .WithMany(s => s.ObjectiveTags)
                .HasForeignKey(sc => sc.ObjectiveId);

            modelBuilder.Entity<ObjectiveTag>()
                .HasOne(sc => sc.Tag)
                .WithMany(c => c.ObjectiveTags)
                .HasForeignKey(sc => sc.TagID);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<ObjectiveTag> ObjectiveTags { get; set; }

    }
}

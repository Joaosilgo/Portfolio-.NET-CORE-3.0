using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace infoSys.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<infoSys.Models.Project> Project { get; set; }
        public DbSet<infoSys.Models.Formation> Formation { get; set; }
        public DbSet<infoSys.Models.ProfessionalExperience> ProfessionalExperience { get; set; }
        public DbSet<infoSys.Models.ProjectResume> ProjectResume { get; set; }
        public DbSet<infoSys.Models.Resume> Resume { get; set; }
        public DbSet<infoSys.Models.ProjectThumbnails> ProjectThumbnails { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Resume>()
        //         .HasMany(b => b.Formations)
        //         .WithOne();
        //}



        //  public DbSet<infoSys.Models.Formation> Formation { get; set; }
        // public DbSet<infoSys.Models.Resume> Resume { get; set; }

        // public DbSet<infoSys.Models.Project> Project { get; set; }
        // public DbSet<infoSys.Models.Project> Project { get; set; }
        // public DbSet<infoSys.Models.Project> Project { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using StudentRelations.Core.Entities;

namespace StudentRelations.DataAccess.Contexts;

public class SGRDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=WIN-PRIFU0D7GO7\SQLEXPRESS;Database=SutGroupRelDb;Trusted_Connection=true;TrustServerCertificate=True");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GroupStudent>()
            .HasKey(gs => new { gs.StudentId, gs.GroupId });
        modelBuilder.Entity<Group>()
            .HasIndex(g => g.Name)
            .IsUnique();
        modelBuilder.Entity<Group>()
            .HasMany(g=>g.GroupStudents)
            .WithOne(gs=>gs.Group)
            .HasForeignKey(gs=>gs.GroupId);
        modelBuilder.Entity<Student>()
            .HasMany(s => s.GroupStudents)
            .WithOne(gs => gs.Student)
            .HasForeignKey(gs => gs.StudentId);
    }

    public DbSet<Student> students { get; set; }
    public DbSet<Group> groups { get; set; }
    public DbSet<GroupStudent> groupStudents { get; set; }
}

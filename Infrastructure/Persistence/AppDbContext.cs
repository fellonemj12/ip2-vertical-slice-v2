using Domain;
using Application.Common;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Persistence;

public class AppDbContext : DbContext, IAppDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Student> Students => Set<Student>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<Admission> Admissions => Set<Admission>();
    public DbSet<AdmissionCourse> AdmissionCourses => Set<AdmissionCourse>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Course configurations
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Title).HasMaxLength(200).IsRequired();
            entity.Property(c => c.Code).HasMaxLength(50).IsRequired();
        });

        // Student configurations
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(s => s.Id);
            entity.Property(s => s.FirstName).HasMaxLength(100).IsRequired();
            entity.Property(s => s.LastName).HasMaxLength(100).IsRequired();
            entity.Property(s => s.Email).HasMaxLength(200).IsRequired();
        });

        // Admission configurations
        modelBuilder.Entity<Admission>(entity =>
        {
            entity.HasKey(a => a.Id);
            entity.HasOne<Student>()
                  .WithMany()
                  .HasForeignKey(a => a.StudentId);
        });

        // AdmissionCourse configurations
        modelBuilder.Entity<AdmissionCourse>(entity =>
        {
            entity.HasKey(ac => new { ac.AdmissionId, ac.CourseId });
            entity.HasOne<Admission>()
                  .WithMany()
                  .HasForeignKey(ac => ac.AdmissionId);
            entity.HasOne<Course>()
                  .WithMany()
                  .HasForeignKey(ac => ac.CourseId);
        });
    }
}
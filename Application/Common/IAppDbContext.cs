using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Application.Common;

public interface IAppDbContext
{
    DbSet<Student> Students { get; }
    DbSet<Course> Courses { get; }
    DbSet<Admission> Admissions { get; }
    DbSet<AdmissionCourse> AdmissionCourses { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}